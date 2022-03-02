using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testapp5mi
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
            dir = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Gorilla Tag";
            this.textBox1.Text = dir;
            
        }
        public string dir = string.Empty;
        public string dir1 = string.Empty;


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.label2.Visible == true)
            {
                this.label2.Visible = false;
                this.textBox2.Visible = false;
                this.button4.Visible = false;
                this.button7.Visible = false;
            }
            else
            {
                this.label2.Visible = true;
                this.textBox2.Visible = true;
                this.button4.Visible = true;
                this.button7.Visible = true;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            dir = this.textBox2.Text;
            this.textBox2.Text = "";
            this.textBox1.Text = dir;
            this.label2.Visible = false;
            this.textBox2.Visible = false;
            this.button4.Visible = false;
            this.button7.Visible = false;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dir = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Gorilla Tag";
            this.textBox1.Text = dir;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dir = "C:\\Program Files\\Oculus\\Software\\Software\\another-axiom-gorilla-tag";
            this.textBox1.Text = dir;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https:////discord.gg////F4Ct8F3wje");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            dir1 = folderBrowserDialog1.SelectedPath;
            this.textBox2.Text = dir1;
        }
    }
}
