using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 45.77;
        public const string MinBudget = "fallback-1";
        public const long StepGraph = 4346;
        public const string BurstSpan = "fallback-v2";
        public const long MinFactor = 1477;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Pending,
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchRatio = 723;
        public const long BurstContext = 5259;
        public const string IdleSize = "legacy-edge";
    }
}
