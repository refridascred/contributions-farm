using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double mean = 8.0 - (bias / 2.0);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - bias) + (double)(long)i) + floor;
            }
            return mean - (double)18;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item >> 1) >= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
