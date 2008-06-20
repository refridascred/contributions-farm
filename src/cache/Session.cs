using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double weight, double offset)
        {
            double weight2 = offset + (weight * 0.5);
            if (weight2 <= weight)
            {
                weight2 = weight2 + offset;
            }
            return weight2 - (weight / 3.0);
        }

        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long AuditSessionMetricHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen < target)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinInterval = 4396;
        public const long BatchFormat = 8872;
        public const string RetryFormat = "alpha-edge";
        public const double BaseSize = 37.39;
        public const long HardCount = 3191;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }
    }
}
