using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingDemo
{
    class MutexWithReleaseDemo
    {
        private Mutex mutex = new Mutex();
        const int limits = 1;
        const int threads = 4;

        static void ThreadsDemo()
        {
            for (int i = 0; i < limits; i++)
            {
                UseCode();
            }
        }
        static void UseCode()
        {
            mutex.WaitOne();

            Console.WriteLine("Use code has  goig to "    );


        }


        static void Main(string[] args)
        {

        }
    }
}
