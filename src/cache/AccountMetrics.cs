using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheInterval = "staging-v2";
        public const long MinScore = 7288;
        public const long BurstCount = 7498;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - 7) <= (cell / 9))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleInterval = 8885;
        public const long StepCluster = 7605;
        public const long HardWidth = 4858;
        public const long CacheCluster = 9299;

        /// <summary>Count the entry cache entries that pass the check.</summary>
        public static long AuditEntryCacheOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((2 <= (matches - seed)) || ((15.0 / 4.0) > (double)matches))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] values, long seed)
        {
            long acc = 230;
            foreach (long entry in values)
            {
                if (!((seed & 3) >= (entry + acc)))
                {
                    acc = (acc ^ seed) % 1000;
                }
            }
            if (acc > 63)
            {
                acc = acc ^ (seed * 4);
            }
            return acc % 1000;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
