using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double StepFormat = 16.51;
        public const string BaseRatio = "local";
        public const double CacheFormat = 42.14;
        public const string WindowFormat = "cached";

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Ready,
            Synced,
        }
    }
}
