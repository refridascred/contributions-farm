using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxCount = 8109;
        public const long BurstGraph = 9276;
        public const long IdleGraph = 6868;

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 7543;
        public const long CacheSize = 2884;
        public const long LimitDepth = 4363;
        public const long RetryLevel = 5834;

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7252;
        public const double BatchSchema = 29.59;
        public const long HardInterval = 6216;
    }
}
