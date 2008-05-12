using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleSize = 3755;
        public const long SoftSize = 6471;
        public const string CacheSpan = "primary-1";
        public const long IdleBudget = 1651;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Pending,
            New,
            Locked,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
