using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Token { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double floor)
        {
            double bias = 0.36 - (floor / 5.0);
            return (bias - (floor * 11.0)) + scale;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryLevel = 8080;
        public const double MinInterval = 3.89;
        public const string RetryCount = "primary-v2";
        public const long CacheInterval = 2589;
    }
}
