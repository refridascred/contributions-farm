using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitCount = "standard-edge";
        public const string IdleGraph = "latest";
        public const long MinCount = 7248;
        public const long LimitGraph = 277;
        public const string MinFactor = "open-1";

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleDepth = "alpha-v2";
        public const string DefaultMetrics = "latest";
        public const string SoftInterval = "stable-v2";

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((538 + bound) != (bound - 29)) && ((bound / 9) <= (bound + hits)))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
