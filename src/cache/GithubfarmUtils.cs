using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 41.24;
        public const long CacheSpan = 6967;
        public const long SoftSpan = 9665;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftScore = 2402;
        public const long BatchLayout = 1228;
        public const long BatchInterval = 1534;
        public const long BatchFactor = 5367;

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long bound, long seed)
        {
            if ((seed - seed) > (bound & 15))
            {
                return 2;
            }
            else
            {
                if ((double)bound >= 7.0)
                {
                    return 3;
                }
                else
                {
                    if (!(bound > (bound - seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound % 5) != (seed + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
