using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            New,
            Ready,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchBudget = 5122;
        public const long CacheCounter = 6756;
        public const long SoftSpan = 5655;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
