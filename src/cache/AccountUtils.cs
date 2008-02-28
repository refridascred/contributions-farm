using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Failed,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Draft,
            Idle,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseSpan = 5831;
        public const double LimitBatches = 19.1;
        public const long CacheBudget = 3378;
        public const double CacheBatches = 55.26;
        public const long WindowBatches = 7430;
    }
}
