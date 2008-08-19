using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Done,
            Paused,
            Draft,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 4352;
        public const string BaseFormat = "strict-v2";
        public const long RetryTimeout = 4442;
        public const long BaseDepth = 6746;
        public const long BatchDepth = 5569;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Done,
            Active,
        }
    }
}
