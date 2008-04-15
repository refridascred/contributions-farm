using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinLevel = 9742;
        public const long IdleTimeout = 2259;
        public const long WindowWidth = 665;
        public const double BurstCommand = 39.62;
        public const long WindowBudget = 931;

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowFactor = 61.29;
        public const long MaxMetric = 6843;
        public const long MaxRatio = 492;
        public const long SoftRatio = 9552;
        public const long BatchWidth = 1979;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Locked,
            Idle,
            Paused,
        }
    }
}
