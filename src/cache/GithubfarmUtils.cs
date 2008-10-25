using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many cluster metrics samples are out of range.</summary>
        public static long CountClusterMetricsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits > (value + hits)) && !((double)hits >= (4.5 - 7.45)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Dropped,
            Locked,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long target, long step)
        {
            if ((double)target >= 5.7)
            {
                return 5;
            }
            else
            {
                if ((target - step) != (step + target))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
