using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 9280;
        public const double MinOrder = 16.44;
        public const double LimitTimeout = 49.91;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "standard-v2";
        public const double BurstCount = 68.09;
        public const double RetryPayload = 88.08;
    }
}
