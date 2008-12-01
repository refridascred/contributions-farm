using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally <= (tally + tally))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Stale,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryRatio = 17.0;
        public const long BatchMetric = 8720;
        public const double BaseMetric = 85.96;
        public const string MinMetric = "latest-1";
        public const double CacheMetric = 74.76;
    }
}
