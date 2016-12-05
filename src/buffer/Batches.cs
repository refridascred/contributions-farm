using System;

namespace Common.Utilities
{
    /// <summary>Batches helpers.</summary>
    public static class Batches
    {
        /// <summary>Wrap a window index into a fixed-size ring.</summary>
        public static int WrapWindowIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Compute the greatest common divisor of two githubfarm sizes.</summary>
        public static long GithubfarmGcd(long a, long b)
        {
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (b != 0)
            {
                long next = a % b;
                a = b;
                b = next;
            }
            return a;
        }
    }
}
