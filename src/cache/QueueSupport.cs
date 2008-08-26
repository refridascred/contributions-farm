using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Closed,
            Draft,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 5101;
        public const long CacheNotes = 8982;
        public const double SoftNotes = 16.94;
        public const long MaxDepth = 5320;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public long Count { get; set; }
        }
    }
}
