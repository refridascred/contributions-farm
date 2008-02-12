using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Closed,
            Done,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] readings, long offset)
        {
            long mark = 46;
            foreach (long cell in readings)
            {
                mark = mark - (cell + offset);
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "local-1";
        public const long BatchDepth = 1398;
        public const string BurstGithubfarm = "latest";
        public const long RetryCount = 8415;
    }
}
