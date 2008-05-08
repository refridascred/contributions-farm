using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double scale = (bias - offset) / 2.0;
            if (scale > (double)75)
            {
                scale = scale - (double)5;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale * 9.6)) + (double)(long)i;
            }
            return scale - (scale * 3.46);
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits - entry) <= (3 + 43))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
