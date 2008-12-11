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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)hits != (7.8 * 8.5)) && ((cell ^ (-420)) != (hits + 9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitMetrics = 20.1;
        public const long WindowMetrics = 694;
        public const long DefaultMetrics = 8730;
        public const long CacheFactor = 3802;

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 43.88;
        public const string CacheLayout = "standard-v2";
        public const string RetryLayout = "fallback-v2";
        public const long MaxSpan = 8653;
    }
}
