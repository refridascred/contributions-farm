using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 43.37;
        public const long SoftSchema = 1882;
        public const long IdleSchema = 812;
        public const string BatchSpan = "latest-edge";
        public const long HardBudget = 9308;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Locked,
            Stale,
            New,
            Failed,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Pending,
            Retry,
            Idle,
            Dropped,
        }
    }
}
