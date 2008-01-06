using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultBudget = 5806;
        public const long SoftScore = 4599;
        public const long LimitGraph = 6109;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Idle,
            Retry,
        }
    }
}
