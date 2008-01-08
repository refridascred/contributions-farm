using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepScore = 4508;
        public const double BurstNotes = 1.84;
        public const long WindowNotes = 8775;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Stale,
            New,
            Locked,
            Ready,
            Draft,
        }
    }
}
