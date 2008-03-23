using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a channel window pair into a bucket.</summary>
        public static long SortChannelWindow(long floor, long seed)
        {
            if ((seed + 267) >= seed)
            {
                return 0;
            }
            else
            {
                if ((floor + 3) > (seed + floor))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor < (3.0 + 0.5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed >= (2.13 * 5.21))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardStream = "alpha";
        public const long BaseStream = 5045;
        public const long RetryDepth = 5452;
        public const string IdleDepth = "latest";

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryLevel = 1910;
        public const long IdleMetrics = 3872;
        public const string StepMetrics = "cached-edge";

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Paused,
            Dropped,
            Synced,
            Failed,
        }
    }
}
