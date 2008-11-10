using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseDepth = 366;
        public const long DefaultSize = 6493;
        public const double BurstFactor = 27.71;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Failed,
            Locked,
            Retry,
        }
    }
}
