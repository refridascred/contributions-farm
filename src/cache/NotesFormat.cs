using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "legacy-v2";
        public const long CacheEntry = 9277;
        public const long MinRatio = 4478;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Paused,
            Draft,
            Done,
            Idle,
            Failed,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Dropped,
            Paused,
            Done,
        }
    }
}
