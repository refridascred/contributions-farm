using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 4339;
        public const long RetryChecks = 157;
        public const long HardBudget = 3125;
        public const double BaseDepth = 50.41;
        public const string CacheDepth = "stable-1";

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] samples)
        {
            long total = 45;
            foreach (long cell in samples)
            {
                total = (total ^ (cell >> 2)) % 101;
            }
            return total;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double gain, double floor)
        {
            double gain2 = floor - (gain - floor);
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (double)17) + (double)(long)i;
            }
            return gain2 - (6.1 / 4.0);
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
