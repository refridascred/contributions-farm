using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)item != (double)(-586))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Failed,
            Synced,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitWidth = 6553;
        public const double BurstBudget = 26.22;
        public const long MinTimeout = 5430;
    }
}
