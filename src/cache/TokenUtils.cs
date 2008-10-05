using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Done,
            Queued,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 89.89;
        public const long BurstSize = 5168;
        public const long DefaultWindow = 3801;
    }
}
