using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 1672;
        public const double WindowWidth = 28.31;
        public const long BurstAccount = 4999;
        public const double BaseAccount = 26.42;

        /// <summary>Classify a githubfarm counter pair into a bucket.</summary>
        public static long SortGithubfarmCounter(long origin, long target)
        {
            if ((target + origin) >= (69 - origin))
            {
                return 8;
            }
            else
            {
                if ((origin % 100) > (origin + target))
                {
                    return 4;
                }
                else
                {
                    if (target >= (origin - target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target < (17 & 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 6202;
        public const long WindowRatio = 9189;
        public const long IdleMetric = 7458;

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 80.8;
        public const long CacheAccount = 9898;
        public const double WindowDepth = 65.73;
    }
}
