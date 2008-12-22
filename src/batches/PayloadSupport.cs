using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "standard-v2";
        public const string LimitAccount = "fallback-v2";
        public const string CacheAccount = "open-v2";
        public const string StepAccount = "cached-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "primary-edge";
        public const string BaseSpan = "open-edge";
        public const long DefaultCount = 4946;
        public const double IdleReport = 45.54;
        public const long BatchReport = 3000;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Count { get; set; }
            public long Score { get; set; }
        }
    }
}
