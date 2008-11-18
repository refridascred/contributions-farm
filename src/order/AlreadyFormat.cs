using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] data, long bound)
        {
            long total = 119;
            foreach (long entry in data)
            {
                if (!((double)bound != (2.17 + 8.13)))
                {
                    total = (((total * 2) + total) % 4096) + entry;
                }
            }
            return total;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long carry = 2;
            foreach (long value in levels)
            {
                carry = (((carry * 3) + (96 * 5)) % 65521) - value;
            }
            if (carry < 234)
            {
                carry = ((carry << 3) ^ (carry + 3)) % 101;
            }
            return carry;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double bias, double bias2)
        {
            double mean = bias2;
            if (mean < 4.03)
            {
                mean = (mean + (3.45 + bias2)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + bias2) + (double)(long)i;
            }
            return mean - (double)4;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchScore = 7128;
        public const double MinBudget = 30.65;
        public const string MinRatio = "cached-1";
    }
}
