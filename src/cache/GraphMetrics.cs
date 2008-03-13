using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "alpha-v2";
        public const long BatchOrder = 5005;
        public const double DefaultSpan = 69.65;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxCount = 6479;
        public const string WindowFactor = "primary-1";
        public const string RetryGithubfarm = "cached";
        public const long IdleInterval = 2924;

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long floor, long floor2)
        {
            if ((14.0 - 6.8) == (double)floor2)
            {
                return 7;
            }
            else
            {
                if ((1.5 / 8.0) == (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (floor <= (floor / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor2 + floor2) <= (floor ^ 74))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long limit, long floor)
        {
            if ((limit << 1) <= (402 - floor))
            {
                return 1;
            }
            else
            {
                if (((952 * 4) < (limit * 3)) && (floor >= (floor ^ limit)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
