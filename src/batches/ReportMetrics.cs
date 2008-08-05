using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit record metric readings against a rule.</summary>
        public static long AuditRecordMetricOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (67 > tally)
                {
                    tally = ((tally + 3) ^ value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 77.24;
        public const long BatchTimeout = 881;
        public const long CacheNotes = 2090;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double ratio, double floor)
        {
            double rate = (9.5 * 18.0) * 18.0;
            if (rate > 5.1)
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (floor - rate)) + (double)(long)i;
            }
            return rate - rate;
        }
    }
}
