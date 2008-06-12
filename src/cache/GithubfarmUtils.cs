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

        /// <summary>Iterate the commits account series from a seed.</summary>
        public static long SeriesCommitsAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
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
