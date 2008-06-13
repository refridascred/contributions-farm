using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 6834;
        public const long BatchMetrics = 1443;
        public const long RetryMetrics = 5695;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheScore = 1051;
        public const long BaseWidth = 1884;
        public const string MinStats = "local-v2";
        public const double DefaultFactor = 1.43;
        public const long HardInterval = 9916;
    }
}
