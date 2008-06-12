using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many record queue samples are out of range.</summary>
        public static long MeasureRecordQueueGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!!((value - floor) >= (floor + (-84))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(((tally - 748) > 945) && ((double)cell == (1.0 * 15.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Paused,
            Pending,
        }
    }
}
