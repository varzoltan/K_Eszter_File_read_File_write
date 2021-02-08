using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Névtér változás: InputOutput
using System.IO;

namespace K_Eszter_File_read_File_write
{
    class Program
    {
        static void Main(string[] args)
        {
            //fájlból olvasás
            string[] fajlbol_olvas = new string[500];
            StreamReader olvas = new StreamReader(@"C:\Users\Rendszergazda\eszter.txt");
            int i = 0;
            while (!olvas.EndOfStream)
            {
                fajlbol_olvas[i] = olvas.ReadLine();
                i++;
            }
            olvas.Close();

            //Írjuk ki a tömb elemit
            //Console.WriteLine(fajlbol_olvas[0]);
            for (int j = 0;j<i;j++)
            {
                Console.WriteLine(fajlbol_olvas[j]);
            }


            //fájlba írás
            StreamWriter ir = new StreamWriter(@"C:\Users\Rendszergazda\eszter_ir.txt");
            for (int j = 0;j<i;j++)
            {
                ir.Write(fajlbol_olvas[j] + " ");
            }
            ir.Close();
            Console.ReadKey();
        }
    }
}
