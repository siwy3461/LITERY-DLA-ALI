using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int l;
       
       

        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            l = 0;




        }


        private void button1_Click(object sender, EventArgs e) {
            label5.Text = label1.Text;
                Random random = new Random();
                int randomNumber = random.Next(0, 24);
                
                    


                String[] lit = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "W", "Y", "Z", " " };
                if (lit[randomNumber]== label5.Text)
            {
                randomNumber = random.Next(0, 24);
            }

            label1.Text = lit[randomNumber];
            
            l++;
            
            if (l == 10)
            {
                label2.Text = "10";
                progressBar1.Value = l;
                
                button1.Visible = false;
                button2.Visible = true;
            }
            else
            {
                label2.Text = l.ToString();
                progressBar1.Value = l;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            l = 0;
            label2.Text = l.ToString();
            progressBar1.Value = l;
            label1.Text = "#";
            button1.Visible = true;
            button2.Visible = false;
        }
    }
}
