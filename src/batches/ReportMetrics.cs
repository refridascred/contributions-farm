using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "standard-v2";
        public const long CacheSpan = 3859;
        public const long WindowRatio = 3343;

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 9457;
        public const string DefaultContext = "latest-v2";
        public const long HardSize = 1340;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowFactor = 2415;
        public const long WindowCluster = 7136;
        public const double LimitBudget = 22.96;
        public const long SoftCluster = 4670;
        public const long CacheCluster = 7452;
    }
}
