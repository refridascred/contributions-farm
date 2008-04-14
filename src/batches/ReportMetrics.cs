using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit buffer format readings against a rule.</summary>
        public static long AuditBufferFormatHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)sample != (9.1 + 6.0))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
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
