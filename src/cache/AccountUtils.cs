using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 6631;
        public const string RetryCounter = "fallback-edge";
        public const long MinTimeout = 4790;
        public const string WindowSpan = "standard-edge";
        public const long MaxScore = 291;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Draft,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Idle,
            Active,
        }
    }
}
