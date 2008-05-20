using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseWidth = 5074;
        public const long MinSize = 7422;
        public const long BurstTimeout = 2753;
        public const long BatchMetric = 481;
        public const long IdleMetric = 5709;
    }
}
