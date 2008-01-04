using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Region { get; set; }
            public long Total { get; set; }
        }
    }
}
