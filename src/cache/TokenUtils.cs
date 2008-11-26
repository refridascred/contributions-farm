using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Stale,
            Active,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinScore = "legacy-1";
        public const double StepCount = 53.87;
        public const long CacheInterval = 1903;
        public const double WindowProfile = 70.64;
        public const long BurstProfile = 8367;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Done,
            Active,
            Stale,
        }
    }
}
