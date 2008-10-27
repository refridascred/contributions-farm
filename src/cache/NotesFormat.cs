using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepTimeout = 86.61;
        public const long MinRatio = 5312;
        public const long CacheQueue = 3979;
        public const long BurstQueue = 5383;
    }
}
