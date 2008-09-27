using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry > (hits - seed))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Active,
            Synced,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinLevel = 3937;
        public const long MinTimeout = 8460;
        public const long StepSpan = 1381;
        public const string BurstSize = "legacy-1";
    }
}
