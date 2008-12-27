using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Idle,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 7927;
        public const double LimitPayload = 27.33;
        public const long BatchPayload = 6961;
        public const long IdleFactor = 326;
    }
}
