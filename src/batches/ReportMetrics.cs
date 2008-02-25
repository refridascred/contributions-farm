using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string LimitBudget = "open-1";
        public const string BatchCount = "open";
        public const double BurstReport = 32.35;
        public const double MaxReport = 64.28;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Count the context checks entries that pass the check.</summary>
        public static long AuditContextChecksHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((count / 3) < (count - count)) || ((4.5 / 4.0) <= (double)origin))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
