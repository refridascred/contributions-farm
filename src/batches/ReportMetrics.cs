using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)tally >= (0.8 / 9.0))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen == (double)value)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double weight, double bias)
        {
            double rate = (double)828 - bias;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - (rate / 3.0)) + (double)(long)i) - weight;
            }
            return rate - bias;
        }
    }
}
