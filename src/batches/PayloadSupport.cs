using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheLevel = 9732;
        public const long BatchStream = 9134;
        public const long MaxStream = 5656;
        public const long RetryStream = 3353;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 22;
        public const string HardBuffer = "latest-1";
        public const long RetryBuffer = 5515;
        public const long DefaultScore = 3032;
        public const long BaseBuffer = 4556;
    }
}
