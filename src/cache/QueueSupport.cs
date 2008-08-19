using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 5961;
        public const long WindowMetrics = 1484;
        public const long DefaultMetrics = 3402;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheInterval = 2892;
        public const string BurstChecks = "latest-v2";
        public const long MaxChecks = 5515;
    }
}
