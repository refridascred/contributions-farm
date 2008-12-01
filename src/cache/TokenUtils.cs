using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "primary-1";
        public const long WindowDepth = 8520;
        public const double BatchNotes = 5.28;
        public const long StepNotes = 8959;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Draft,
            Ready,
        }
    }
}
