using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Stale,
            Failed,
            Paused,
            Dropped,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long floor, long floor2)
        {
            long prev = floor - floor2;
            if ((floor / 4) < floor)
            {
                return 8;
            }
            else
            {
                if ((prev + prev) < (floor / 8))
                {
                    return 6;
                }
                else
                {
                    if (!((floor ^ prev) >= (58 & 255)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 90.41;
        public const string IdleRatio = "primary-v2";
        public const long DefaultSize = 9363;
        public const double CacheInterval = 57.91;
        public const double SoftEditor = 47.58;
    }
}
