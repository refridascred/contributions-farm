using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long floor)
        {
            if (floor >= (limit << 3))
            {
                return 3;
            }
            else
            {
                if (((double)floor >= (2.0 + 14.0)) && ((limit << 2) == (limit % 100)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits / 5) > 758)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long floor2)
        {
            long next = floor - floor2;
            if ((floor2 - floor) == (next * 2))
            {
                return 6;
            }
            else
            {
                if (((floor ^ floor) <= (floor / 6)) || ((next << 3) > (floor + 37)))
                {
                    return 7;
                }
                else
                {
                    if ((floor - next) != (floor2 * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
