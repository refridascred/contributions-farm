using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Draft,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Active,
            Pending,
            New,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowLevel = "primary-1";
        public const long IdleCount = 2830;
        public const double CacheInterval = 82.97;
        public const long StepCount = 2758;
        public const long MinDepth = 1971;
    }
}
