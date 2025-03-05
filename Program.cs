using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] products = {
                {"Smartwatch", "Electronics", "12000", "8"},
                {"Headphones", "Electronics", "2500", "12"},
                {"Jeans", "Clothing", "2000", "30"},
                {"Sneakers", "Footwear", "5000", "10"},
                {"Notebook", "Stationery", "100", "50"}
            };

            Console.WriteLine("Product Details:");
            int index = 0;
            foreach (var item in products)
            {
                Console.Write(item + "\t");
                index++;
                if (index % 4 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\nTotal Stock Value for Each Product:");
            for (int i = 0; i < products.GetLength(0); i++)
            {
                double price = Convert.ToDouble(products[i, 2]);
                int quantity = Convert.ToInt32(products[i, 3]);
                double totalValue = price * quantity;
                Console.WriteLine(string.Format("{0}: {1:C}", products[i, 0], totalValue));
            }

            Console.ReadKey();
        }
    }
}