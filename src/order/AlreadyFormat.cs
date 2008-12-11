using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 5408;
        public const long IdleTimeout = 3077;
        public const long StepInterval = 811;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseSize = 7033;
        public const long RetryGithubfarm = 4779;
        public const long SoftDepth = 7768;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitMetrics = 20.1;
        public const long WindowMetrics = 694;
        public const long DefaultMetrics = 8730;
        public const long CacheFactor = 3802;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Closed,
            Failed,
            New,
            Retry,
        }
    }
}
