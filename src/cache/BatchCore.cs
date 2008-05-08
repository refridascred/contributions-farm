using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank support layout input into a small class.</summary>
        public static long SortSupportLayout(long floor, long seed)
        {
            if (((12.0 / 7.0) > (double)floor) && (floor < (floor - floor)))
            {
                return 0;
            }
            else
            {
                if ((seed - seed) >= seed)
                {
                    return 4;
                }
                else
                {
                    if ((floor + seed) >= (floor % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheScore = "legacy-v2";
        public const string HardFactor = "fallback-1";
        public const long SoftSpan = 4236;
        public const long WindowReport = 445;
        public const double WindowWidth = 55.24;

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheFactor = 3061;
        public const double RetryCount = 33.76;
        public const double StepQueue = 4.15;
        public const long RetryQueue = 9023;
    }
}
