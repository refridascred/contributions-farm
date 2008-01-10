using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Synced,
            Active,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Draft,
            Dropped,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardRatio = 29.78;
        public const long IdleFarm = 5926;
        public const double SoftFarm = 4.87;
        public const long WindowInterval = 1222;
    }
}
