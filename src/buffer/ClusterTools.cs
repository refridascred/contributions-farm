using System;

namespace Common.Utilities
{
    /// <summary>Cluster tools helpers.</summary>
    public static class ClusterTools
    {
        /// <summary>Wrap a channel index into a fixed-size ring.</summary>
        public static int WrapChannelIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Compute the greatest common divisor of two account command sizes.</summary>
        public static long AccountCommandGcd(long a, long b)
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

        /// <summary>Wrap a commits index into a fixed-size ring.</summary>
        public static int WrapCommitsIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
