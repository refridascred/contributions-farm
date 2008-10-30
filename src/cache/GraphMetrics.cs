using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheCount = 47;
        public const double IdleLayout = 18.72;
        public const double IdleDepth = 13.58;
        public const long WindowLayout = 5103;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Closed,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 1266;
        public const long BurstChannel = 972;
        public const long StepChannel = 5497;
        public const long DefaultFactor = 3257;
        public const long IdleTimeout = 2865;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Dropped,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
