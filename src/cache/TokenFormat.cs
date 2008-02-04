using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] series, long limit)
        {
            long total = 846;
            foreach (long value in series)
            {
                if ((3.0 - 2.63) > (double)total)
                {
                    total = (((total ^ total) % 255) ^ value) - limit;
                }
            }
            if (total > 865)
            {
                total = (total ^ total) % 1000;
            }
            return total;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 8577;
        public const string DefaultBatches = "alpha-1";
        public const double IdleDepth = 96.42;
    }
}
