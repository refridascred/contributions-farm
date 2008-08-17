using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first support counter entry that matches the target.</summary>
        public static long LocateSupportCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 3673;
        public const string BurstBatch = "stable-edge";
        public const long BurstSpan = 2477;

        /// <summary>Classify a batches metric pair into a bucket.</summary>
        public static long SortBatchesMetric(long seed, long limit)
        {
            if ((limit * 4) > (seed * 2))
            {
                return 3;
            }
            else
            {
                if ((limit % 64) >= (limit + limit))
                {
                    return 0;
                }
                else
                {
                    if (!((limit - 138) >= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8507;
        public const long CacheSpan = 5530;
        public const long DefaultWidth = 4077;
        public const long MinBatches = 5014;
        public const string BurstCount = "stable-edge";
    }
}
