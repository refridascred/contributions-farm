using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Draft,
            New,
            Locked,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public bool Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
