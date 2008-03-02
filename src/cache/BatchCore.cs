using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 6335;
        public const long BatchChannel = 6970;
        public const long RetryChannel = 6902;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Stale,
            Retry,
        }
    }
}
