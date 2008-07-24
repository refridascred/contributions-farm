using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 9380;
        public const long MaxRatio = 5341;
        public const double MaxBatch = 32.34;
        public const long CacheBatch = 4508;
        public const long CacheWidth = 343;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long limit, long offset)
        {
            if ((limit << 3) <= (offset << 2))
            {
                return 5;
            }
            else
            {
                if (((6.9 * 1.0) < (double)offset) && ((limit << 2) > (offset + offset)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
