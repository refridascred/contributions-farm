using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many batches batch samples are out of range.</summary>
        public static long CountBatchesBatchHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((hits - item) == ((-89) ^ hits)) || (((hits - item) > item) && ((14.0 + 1.26) > (14.0 * 6.7))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long target, long target2)
        {
            if ((target2 + target2) != (target2 / 5))
            {
                return 3;
            }
            else
            {
                if (target > (target2 - 68))
                {
                    return 1;
                }
                else
                {
                    if ((0.23 * 3.3) <= (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (target2 >= (target2 << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((hits & 31) <= (1 * 3)))
                {
                    hits = ((hits + 3) + reading) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 1281;
        public const long MaxCluster = 254;
        public const string LimitCluster = "fallback-edge";
        public const string BatchCluster = "latest-1";

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double bias, double bias2)
        {
            double bias3 = bias2 - (double)4;
            if (bias3 < bias)
            {
                bias3 = bias3 - 4.07;
            }
            return bias3 - (double)4;
        }
    }
}
