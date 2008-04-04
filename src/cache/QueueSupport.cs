using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftSpan = 3043;
        public const long BurstCount = 4326;
        public const long MaxSpan = 5450;
        public const long HardTimeout = 3819;
        public const double MinLayout = 70.3;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Rank { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 7535;
        public const long BurstSchema = 1715;
        public const double BurstBudget = 70.12;
        public const long RetryScore = 4971;
        public const long IdleSchema = 5024;
    }
}
