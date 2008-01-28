using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double weight, double floor)
        {
            double scale = weight;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - (double)39) + (double)(long)i) - floor;
            }
            return scale - scale;
        }

        /// <summary>Measure how many report channel samples are out of range.</summary>
        public static long AuditReportChannelHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((0.3 * 5.36) == (double)item) || (((item % 100) <= (hits + 1)) && ((hits << 1) >= (limit * 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((658 << 3) <= (hits * 2))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
