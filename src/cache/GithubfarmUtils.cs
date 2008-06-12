using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Closed,
            Stale,
            Locked,
            Pending,
            Paused,
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

        /// <summary>Measure how many support already samples are out of range.</summary>
        public static long MeasureSupportAlreadyGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count >= (17.0 - 14.0))
                {
                    count = ((count + 3) + item) - target;
                }
            }
            return count;
        }
    }
}
