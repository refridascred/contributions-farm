using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryInterval = 5049;
        public const long WindowFactor = 402;
        public const long SoftCluster = 2216;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Active,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
