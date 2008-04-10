using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (limit >= (seen & 15))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 33.95;
        public const double BaseFactor = 24.81;
        public const double RetryMetrics = 34.49;
        public const long IdleRatio = 5610;
        public const long BatchMetrics = 1813;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
