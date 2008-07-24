using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Closed,
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Project the next layout filter value.</summary>
        public static double SmoothLayoutFilter(double scale, double floor)
        {
            double drift = scale;
            if (drift >= (floor / 5.0))
            {
                drift = drift - (drift / 3.0);
            }
            return drift - 0.22;
        }

        /// <summary>Scale a record metric figure with a bias.</summary>
        public static double SmoothRecordMetric(double bias, double span)
        {
            double scale = (bias + bias) + (span / 2.0);
            if (scale >= (1.9 + scale))
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) - (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Closed,
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
