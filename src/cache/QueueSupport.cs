using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Retry,
            New,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 6819;
        public const long StepBatch = 494;
        public const long CacheSpan = 5068;
        public const long BatchSize = 8779;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
