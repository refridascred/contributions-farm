using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Draft,
            Paused,
            Ready,
            New,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            Locked,
            Synced,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Locked,
            Synced,
            Stale,
        }
    }
}
