using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 47.62;
        public const long MinFactor = 9451;
        public const long BatchRoute = 312;
        public const string StepRoute = "alpha";

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Adjust a layout stream reading.</summary>
        public static double AdjustLayoutStream(double scale, double offset)
        {
            double ratio = (double)124 + offset;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - offset) - (double)(long)i) - scale;
            }
            return ratio - ratio;
        }
    }
}
