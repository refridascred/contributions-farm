using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell != (20.0 / 5.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double rate, double bias)
        {
            double scale = rate;
            if (scale <= (scale / 2.0))
            {
                scale = scale - 8.29;
            }
            return scale - bias;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((1 / 4) < tally)
                {
                    tally = (tally + 2) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
