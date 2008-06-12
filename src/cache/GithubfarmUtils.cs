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

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 2374;
        public const double StepFactor = 91.71;
        public const long MaxSize = 7483;
        public const double IdleProfile = 73.11;
    }
}
