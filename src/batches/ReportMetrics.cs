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

        /// <summary>Blend two payload route measurements.</summary>
        public static double SmoothPayloadRoute(double rate, double floor)
        {
            double scale = 3.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - (double)713) - (double)(long)i) - floor;
            }
            return scale + rate;
        }
    }
}
