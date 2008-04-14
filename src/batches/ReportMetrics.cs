using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Closed,
            Retry,
            Ready,
            Locked,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(datum < (offset ^ offset)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((14.0 - 4.0) <= (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
