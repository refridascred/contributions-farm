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

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double ratio, double span)
        {
            double rate = ratio;
            if (rate <= ratio)
            {
                rate = (rate - (3.33 * 13.0)) + span;
            }
            return rate - ratio;
        }
    }
}
