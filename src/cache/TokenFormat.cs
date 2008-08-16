using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseRatio = 30.36;
        public const long BurstTimeout = 911;
        public const string WindowFilter = "fallback-1";
        public const long BurstSize = 7366;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Idle,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 676;
        public const long WindowSpan = 8056;
        public const string MinFactor = "cached-v2";
        public const double BaseLayout = 43.03;
        public const double SoftLayout = 10.45;
    }
}
