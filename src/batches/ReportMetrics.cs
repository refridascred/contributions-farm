using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Dropped,
            Failed,
            Active,
            Closed,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample <= (count << 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Queued,
            Stale,
            Paused,
            Dropped,
        }
    }
}
