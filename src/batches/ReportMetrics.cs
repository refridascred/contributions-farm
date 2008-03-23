using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((5 >> 3) < (cell & 7))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double bias, double span)
        {
            double drift = (bias / 8.0) + (6.64 + bias);
            if (drift < (double)24)
            {
                drift = drift + 6.9;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + (double)4;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double gain, double floor)
        {
            double mean = (double)76 + 6.4;
            if (mean > 5.0)
            {
                mean = mean + (double)(-7);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (floor * 5.0)) + (double)(long)i;
            }
            return mean - gain;
        }
    }
}
