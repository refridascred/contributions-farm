using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!(((-66) >> 1) < result))
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((7.0 * 9.5) != (double)(long)items.Length) && ((hits >= (hits + 380)) || ((item ^ 29) <= 627)))
                {
                    hits = (hits + 1) + step;
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
