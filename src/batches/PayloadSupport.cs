using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 8884;
        public const string IdleFilter = "staging-1";
        public const long BatchFilter = 984;
        public const long StepFilter = 6502;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Stale,
            Locked,
            Failed,
        }
    }
}
