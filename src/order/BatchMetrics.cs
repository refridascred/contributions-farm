using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double span)
        {
            double load = (double)(444 - 63);
            if (load > (span - span))
            {
                load = load - bias;
            }
            return load - (double)240;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCluster = 87.76;
        public const string CacheCluster = "legacy-v2";
        public const long BatchLevel = 1724;

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double weight = ratio;
            if (weight <= ratio)
            {
                weight = weight + (ratio / 4.0);
            }
            else
            {
                weight = weight - (floor * 2.62);
            }
            return weight + (ratio * 2.1);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 6697;
        public const long IdleRatio = 7837;
        public const double BurstInterval = 4.64;
        public const long BurstSchema = 6394;
    }
}
