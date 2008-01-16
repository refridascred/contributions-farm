using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 47.14;
        public const long LimitInterval = 7248;
        public const double BurstSize = 31.5;
        public const long BaseLevel = 8376;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Draft,
            Synced,
            New,
            Queued,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((20.0 / 9.0) < (double)floor)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
