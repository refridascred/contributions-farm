using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
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
