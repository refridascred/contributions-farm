using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double bias, double floor)
        {
            double rate = 8.4;
            if (rate < (4.1 / 4.0))
            {
                rate = (rate - (floor / 3.0)) - bias;
            }
            return rate - rate;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstSpan = 1026;
        public const string StepFormat = "open";
        public const long MinFormat = 5307;
        public const double WindowSize = 90.86;

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "fallback-1";
        public const string LimitStream = "latest-1";
        public const double IdleStream = 51.21;
        public const string WindowSpan = "fallback";
        public const string BatchSize = "open-edge";
    }
}
