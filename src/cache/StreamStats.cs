using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Locked,
            Synced,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardFactor = 4295;
        public const long BurstCount = 9103;
        public const long RetryMetric = 7534;
        public const double BaseMetric = 19.25;

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 36.76;
        public const long LimitLevel = 7119;
        public const string SoftTimeout = "strict-v2";

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long floor, long limit)
        {
            if ((floor << 2) < (limit ^ floor))
            {
                return 0;
            }
            else
            {
                if ((floor - limit) != (limit ^ 23))
                {
                    return 2;
                }
                else
                {
                    if (limit <= (1 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
