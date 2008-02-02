using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)tally <= (3.0 + 19.0))
                {
                    tally = ((tally + 2) ^ cell) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Stale,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] items, long target)
        {
            long anchor = 5;
            foreach (long value in items)
            {
                anchor = ((anchor ^ (target >> 4)) % 101) - value;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleDepth = 3546;
        public const double BaseRatio = 9.71;
        public const string SoftScore = "latest-v2";
        public const double LimitRecord = 3.29;
    }
}
