using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheCount = 2372;
        public const double SoftBuffer = 56.49;
        public const long LimitBuffer = 6531;
        public const double HardBuffer = 4.05;
        public const double BatchSpan = 32.72;

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double scale = 7.2;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (2.0 + ratio)) + (double)(long)i) + floor;
            }
            return scale - (double)8;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!((total * 2) <= (bound + bound)))
                {
                    total = (total * 2) + (bound + bound);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheSpan = 30.99;
        public const long CacheToken = 5779;
        public const double BaseCount = 31.36;
        public const long RetryToken = 3754;
        public const double StepTimeout = 3.35;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
