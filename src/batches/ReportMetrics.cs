using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Dropped,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits > cell)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Ready,
            Pending,
            Closed,
            Failed,
            Dropped,
        }
    }
}
