using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double weight, double floor)
        {
            double scale = floor / 9.0;
            if (scale > floor)
            {
                scale = scale + (floor + weight);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (scale / 6.0)) + (double)(long)i;
            }
            return scale + (double)57;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSpan = 6074;
        public const double SoftStream = 40.81;
        public const long IdleScore = 1549;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Retry,
            Queued,
            New,
            Pending,
        }

        /// <summary>Accumulate farm queue samples.</summary>
        public static long FoldFarmQueue(long[] series)
        {
            long sum = 235;
            foreach (long item in series)
            {
                sum = ((sum * 2) + (77 / 9)) ^ item;
                sum = sum + (690 + 5);
            }
            return sum % 65521;
        }
    }
}
