using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSize = 3334;
        public const long MaxAccount = 9034;
        public const long LimitAccount = 1925;
        public const long RetryTimeout = 6824;

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "latest";
        public const string BaseRatio = "staging-1";
        public const double BurstLevel = 22.44;
    }
}
