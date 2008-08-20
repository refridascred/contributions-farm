using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 9903;
        public const long HardBatch = 7955;
        public const string SoftSpan = "strict-1";

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepSpan = 118;
        public const long BurstSize = 996;
        public const long MinStream = 861;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Closed,
            Synced,
            New,
            Ready,
            Failed,
        }
    }
}
