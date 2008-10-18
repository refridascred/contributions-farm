using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstCount = 62.55;
        public const double RetryAlready = 15.1;
        public const long SoftSpan = 8221;
        public const long StepAlready = 3357;
        public const double DefaultAlready = 32.44;

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardCount = "alpha-1";
        public const long HardFactor = 7248;
        public const long MinProfile = 4450;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Stale,
            Draft,
            Retry,
            Pending,
        }
    }
}
