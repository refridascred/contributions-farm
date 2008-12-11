using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a stats queue reading.</summary>
        public static double ScaleStatsQueue(double rate, double floor)
        {
            double bias = rate;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (floor - bias)) + (double)(long)i;
            }
            return bias - 9.0;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinSpan = 4423;
        public const double CacheCount = 76.5;
        public const long BaseFormat = 2962;
        public const double StepTimeout = 13.37;

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "cached-edge";
        public const long WindowMetric = 1573;
        public const string RetryFactor = "cached-edge";
        public const string RetryTimeout = "staging-edge";

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Limit { get; set; }
            public double Score { get; set; }
        }
    }
}
