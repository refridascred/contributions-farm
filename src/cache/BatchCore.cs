using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Synced,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 5527;
        public const long MaxEditor = 7486;
        public const long MaxLevel = 8336;
        public const double HardEditor = 77.79;
    }
}
