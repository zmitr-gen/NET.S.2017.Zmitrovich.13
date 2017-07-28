﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue0=new Queue<int>();
            queue0.Enqueue(4);
            queue0.Enqueue(5);
            queue0.Enqueue(6);
            ShowQueue(queue0);

            queue0.Dequeue();
            ShowQueue(queue0);

            Console.WriteLine("First element is "+queue0.Peek());
            Console.WriteLine("Count of elements: "+queue0.Count);
            
            queue0.Clear();
            ShowQueue(queue0);

            Queue<int> queue1 = new Queue<int>(new int[] { 1, 4, 2, 1, 4, 5 });
            queue1.Enqueue(12);
            ShowQueue(queue1);

        }

        static void ShowQueue<T>(Queue<T> queue)
        {
            Console.WriteLine("\nNow in queue: ");

            foreach (T q in queue)
            {
                Console.WriteLine(q+" ");
            }
        }
    }
}