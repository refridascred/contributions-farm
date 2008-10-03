using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepTimeout = 1068;
        public const string BurstInterval = "primary-1";
        public const long CacheMetrics = 1310;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long origin)
        {
            if (limit < (origin / 2))
            {
                return 1;
            }
            else
            {
                if (!(origin > (limit ^ limit)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "staging-1";
        public const double BaseContributi = 44.49;
        public const long WindowContributi = 9126;
    }
}
