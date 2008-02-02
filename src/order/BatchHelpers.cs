using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Pending,
            Active,
            Queued,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Draft,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 3797;
        public const long IdleRoute = 9171;
        public const long BaseSpan = 5984;
    }
}
