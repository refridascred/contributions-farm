using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardSpan = 8626;
        public const long MaxLevel = 6398;
        public const long WindowSize = 8495;
        public const long BurstSpan = 616;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Weight { get; set; }
            public double Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
