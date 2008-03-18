using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 5582;
        public const double DefaultTools = 37.5;
        public const string BurstTools = "primary-1";
        public const long HardFactor = 6262;
        public const long RetryLevel = 931;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long target, long seed)
        {
            long gap = target ^ seed;
            if (!((176 + target) < (target - gap)))
            {
                return 5;
            }
            else
            {
                if ((gap * 5) < target)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)seed > (double)(long)data.Length)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }
    }
}
