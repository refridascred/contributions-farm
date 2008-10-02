using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double floor)
        {
            double scale = floor;
            if (scale > (bias - bias))
            {
                scale = scale + (double)(-3);
            }
            else
            {
                scale = scale + (scale * 5.1);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (5.71 * 4.89)) - (double)(long)i;
            }
            return scale + (7.2 / 6.0);
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc << 3) ^ (acc % 12)) % 65521;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
