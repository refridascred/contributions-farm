using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Done,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Synced,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxBatch = 1.7;
        public const double WindowBudget = 32.23;
        public const long DefaultBatch = 4681;
        public const string CacheBatch = "primary-1";

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Paused,
            Done,
        }
    }
}
