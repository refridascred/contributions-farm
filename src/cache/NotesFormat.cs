using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 3165;
        public const long BatchFilter = 2853;
        public const double RetryWidth = 80.52;
        public const string MaxFilter = "standard-edge";

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
