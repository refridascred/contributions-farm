using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a channel schema pair into a bucket.</summary>
        public static long BucketChannelSchema(long seed, long floor)
        {
            if ((seed + seed) > (29 + floor))
            {
                return 8;
            }
            else
            {
                if ((double)seed == (4.71 + 19.0))
                {
                    return 1;
                }
                else
                {
                    if (!((seed * 2) > floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 5970;
        public const double CacheInterval = 75.69;
        public const string MaxCount = "fallback";

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowWidth = 97.24;
        public const long BatchFarm = 2964;
        public const string HardFarm = "staging-1";
    }
}
