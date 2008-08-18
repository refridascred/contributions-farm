using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepDepth = 8689;
        public const long BurstToken = 9872;
        public const long BaseRatio = 2573;
        public const double HardCount = 92.16;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
