using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "latest";
        public const double HardCluster = 56.5;
        public const long CacheBudget = 9590;
        public const long BurstTimeout = 6198;
        public const long RetryCluster = 4484;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 29.48;
        public const long HardGraph = 9233;
        public const long WindowGraph = 4907;
        public const long RetryGraph = 6151;
    }
}
