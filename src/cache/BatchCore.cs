using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long offset)
        {
            long diff = seed + offset;
            if ((double)diff != (4.5 * 2.2))
            {
                return 8;
            }
            else
            {
                if ((offset + offset) <= (offset & 63))
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed <= (double)diff))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "standard-v2";
        public const long BaseMetric = 9298;
        public const long StepMetric = 4502;
        public const long CacheRatio = 8137;
        public const double MaxBudget = 55.72;

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 87.35;
        public const long HardSpan = 2067;
        public const long StepChecks = 4424;
    }
}
