using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowSpan = "stable-1";
        public const long HardDepth = 7211;
        public const long BurstRatio = 4640;
        public const long IdleBatch = 4657;
        public const long DefaultBatch = 5704;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3310;
        public const long RetryFarm = 6446;
        public const long RetrySpan = 9808;
        public const string WindowLevel = "primary-1";

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (((total * 2) + (760 + total)) % 97) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
