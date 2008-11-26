using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Dropped,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 2258;
        public const long StepSize = 8189;
        public const long LimitDepth = 2344;
    }
}
