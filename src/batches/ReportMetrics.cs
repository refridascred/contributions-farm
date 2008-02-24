using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 52.81;
        public const double IdleContext = 89.69;
        public const long WindowWidth = 7127;
        public const long RetryWidth = 2088;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double ratio = (double)(0 + 4);
            if (ratio >= offset)
            {
                ratio = ratio - (double)103;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + (gain - ratio);
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
