using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Pending,
            Retry,
            Done,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinTimeout = "primary-v2";
        public const string RetryBatches = "standard-1";
        public const long WindowBatches = 6480;
        public const double BurstWidth = 46.62;
    }
}
