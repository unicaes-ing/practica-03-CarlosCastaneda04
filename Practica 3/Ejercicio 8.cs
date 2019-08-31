using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class Ejercicio_8
    {
        static void Main(string[] args)
        {
            //Ejercicio 8
            double compra, desc = 0, vF;
            string bola = "";
            Console.Write("Compra total del cliente: $");
            compra = Convert.ToDouble(Console.ReadLine());
            Random alea = new Random();
            int num = alea.Next(1, 6);
            Console.WriteLine("Escogiendo bola...");
            Thread.Sleep(2000);
            Console.Clear();
            Console.Write("Usted Sacó una: ");
            switch (num)
            {
                case 1:
                    Console.WriteLine(bola = "Bola Blanca");
                    desc = 0;
                    break;
                case 2:
                    Console.WriteLine(bola = "Bola Verde");
                    desc = compra * 0.15;
                    break;
                case 3:
                    Console.WriteLine(bola = "Bola Amarilla");
                    desc = compra * 0.18;
                    break;
                case 4:
                    Console.WriteLine(bola = "Bola Azul");
                    desc = compra * 0.20;
                    break;
                case 5:
                    Console.WriteLine(bola = "Bola Roja");
                    desc = compra * 0.25;
                    break;
            }
            vF = compra - desc;
            Console.WriteLine("Descuento de la compra por: " + bola + ": " + desc.ToString("C2"));
            Console.WriteLine("Total a pagar: " + vF.ToString("C2"));
            Console.ReadKey();
        }
    }
}
