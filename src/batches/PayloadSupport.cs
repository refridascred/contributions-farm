using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Active,
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitWidth = 3673;
        public const string BaseSpan = "local";
        public const double CacheSpan = 4.02;
        public const long LimitMetric = 4090;
        public const long RetryWidth = 9386;

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCounter = 83.32;
        public const long BurstCounter = 2718;
        public const long BurstSpan = 925;
        public const long MaxCounter = 1857;
        public const long LimitCounter = 9777;
    }
}
