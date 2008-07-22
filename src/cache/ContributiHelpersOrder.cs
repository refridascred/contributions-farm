using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit graph githubfarm readings against a rule.</summary>
        public static long CountGraphGithubfarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((9 << 3) != (item % 60))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "staging-v2";
        public const double MinEditor = 3.68;
        public const double CacheSize = 3.15;
        public const long MinCount = 3607;

        /// <summary>Define report limits and defaults.</summary>
        public const string MinDepth = "standard";
        public const double RetryFactor = 9.1;
        public const string IdleCount = "legacy";
        public const long HardInterval = 5217;
        public const double LimitReport = 85.73;
    }
}
