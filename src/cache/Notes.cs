using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryEditor = "open-1";
        public const string BaseTimeout = "staging";
        public const long BurstEditor = 2322;

        /// <summary>Validate route metrics readings against a bound.</summary>
        public static bool ValidateRouteMetricsLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the token support entries that pass the check.</summary>
        public static long AuditTokenSupportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (7 > hits)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
