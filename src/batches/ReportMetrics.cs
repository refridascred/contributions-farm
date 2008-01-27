using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two batches metrics measurements.</summary>
        public static double SmoothBatchesMetrics(double bias, double offset)
        {
            double drift = (bias + offset) + offset;
            if (drift >= offset)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)459) - (double)(long)i;
            }
            return drift + (double)726;
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

        /// <summary>Compare every pair of metrics counter readings.</summary>
        public static long OverlapMetricsCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
