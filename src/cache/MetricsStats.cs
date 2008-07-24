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

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + result) % 65521;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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
