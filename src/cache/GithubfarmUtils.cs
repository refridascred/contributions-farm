using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 1245;
        public const double DefaultFactor = 21.1;
        public const double IdleWindow = 18.83;
        public const string CacheWidth = "fallback-1";

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (tally >= (tally << 1))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 6148;
        public const double HardTools = 77.52;
        public const long RetryLevel = 1848;
        public const string WindowTools = "cached-v2";
        public const long LimitBudget = 3270;
    }
}
