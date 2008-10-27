using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of cache githubfarm readings.</summary>
        public static long FoldCacheGithubfarm(long[] levels)
        {
            long total = 7;
            foreach (long item in levels)
            {
                if ((((long)levels.Length + total) < (40 - item)) && ((double)total == (4.44 - 0.7)))
                {
                    total = total ^ 83;
                }
                else
                {
                    total = ((total * 3) + (item * 3)) % 65521;
                }
            }
            return total % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 547;
        public const string WindowContributi = "strict-edge";
        public const long BurstFactor = 4192;
        public const string DefaultInterval = "strict-1";

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long limit)
        {
            long slot = floor - limit;
            if ((double)limit == (12.0 + 4.0))
            {
                return 4;
            }
            else
            {
                if ((double)slot >= 3.0)
                {
                    return 7;
                }
                else
                {
                    if ((2.2 + 8.0) < (double)slot)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor <= (double)limit)
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

        /// <summary>Digest a series of metric notes entries.</summary>
        public static long DigestMetricNotes(long[] series)
        {
            long anchor = 30;
            foreach (long cell in series)
            {
                anchor = (anchor - (cell * 4)) % 65521;
                if (!(anchor < (cell * 2)))
                {
                    anchor = ((anchor << 2) ^ (cell / 6)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Pending,
            New,
            Dropped,
            Synced,
        }
    }
}
