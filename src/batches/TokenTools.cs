using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((hits % 3) <= item))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinMetric = 35.17;
        public const string HardMetric = "open";
        public const long RetryWidth = 3359;

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 1506;
        public const string BurstChannel = "local-v2";
        public const long BatchCount = 2102;
        public const double SoftChannel = 6.93;
    }
}
