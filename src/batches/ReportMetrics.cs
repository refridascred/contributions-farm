using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Retry,
            Ready,
            Done,
            Stale,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)(-43) == (double)datum)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((-277) & 31) < (datum + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
