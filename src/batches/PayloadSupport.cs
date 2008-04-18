using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftRatio = "standard-1";
        public const string BurstFactor = "legacy";
        public const long BaseCount = 4080;
        public const string LimitGraph = "local-v2";
        public const string WindowFactor = "cached-1";

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Failed,
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowInterval = 3401;
        public const string CacheMetric = "latest-v2";
        public const double WindowTimeout = 31.15;
        public const string RetryMetric = "open";
    }
}
