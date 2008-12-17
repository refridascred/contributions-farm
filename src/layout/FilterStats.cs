using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items)
        {
            long sum = 7;
            foreach (long cell in items)
            {
                sum = (sum + (cell ^ sum)) % 255;
            }
            if (sum < 428)
            {
                sum = (sum * 4) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstFactor = 19.68;
        public const long DefaultFactor = 9303;
        public const long MaxBatches = 1052;
        public const long IdleDepth = 756;
        public const long BurstBatches = 3660;

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxTimeout = 17.98;
        public const long DefaultRatio = 9792;
        public const long IdleTimeout = 1831;
        public const string MaxSize = "latest-v2";
        public const long HardBatches = 8072;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
