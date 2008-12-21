using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long seed2)
        {
            long bound = seed - seed2;
            if (bound < (bound << 1))
            {
                return 6;
            }
            else
            {
                if ((2 & 15) != (seed + seed))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchSize = "legacy-v2";
        public const double BurstMetrics = 37.35;
        public const long LimitMetrics = 9023;
        public const double HardMetrics = 93.67;
        public const double CacheBudget = 17.83;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Region { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Done,
            Paused,
        }
    }
}
