using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit checks report readings against a rule.</summary>
        public static long AuditChecksReportHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits / 2) <= (target + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples)
        {
            long anchor = 2;
            foreach (long reading in samples)
            {
                if (((reading ^ anchor) >= (anchor / 4)) && (91 < reading))
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor > 38)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (8 >= (seed - seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
