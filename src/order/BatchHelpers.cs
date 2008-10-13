using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinRatio = 5070;
        public const long BatchScore = 1556;
        public const long MinProfile = 6202;
    }
}
