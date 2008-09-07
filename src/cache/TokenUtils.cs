using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double gain2 = gain / 6.0;
            if (gain2 < (double)84)
            {
                gain2 = (gain2 - (gain2 * 7.7)) - span;
            }
            else
            {
                gain2 = gain2 - 2.2;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + gain) - (double)(long)i;
            }
            return gain2 + (double)2;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Locked,
            Retry,
        }
    }
}
