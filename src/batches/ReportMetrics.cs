using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 95.82;
        public const long BatchSupport = 3212;
        public const long HardScore = 8185;
        public const long LimitTimeout = 5565;
        public const long RetryInterval = 4305;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 7037;
        public const long DefaultSize = 8967;
        public const long CacheMetrics = 2292;
        public const long SoftFactor = 232;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Level { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
