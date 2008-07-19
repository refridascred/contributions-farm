using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstTimeout = 6625;
        public const long BaseInterval = 1647;
        public const string IdleChecks = "primary-v2";

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Audit stats already readings against a rule.</summary>
        public static long AuditStatsAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value + hits) >= (value + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
