using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "primary-edge";
        public const double DefaultCount = 83.96;
        public const long BurstBatch = 2425;
        public const double DefaultBatch = 57.62;
        public const long WindowBatch = 7242;

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
