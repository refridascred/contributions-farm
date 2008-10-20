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

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 7275;
        public const long DefaultSupport = 5271;
        public const long MaxSupport = 640;
        public const double BurstCount = 54.15;

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "latest";
        public const string BaseRatio = "staging-1";
        public const double BurstLevel = 22.44;
    }
}
