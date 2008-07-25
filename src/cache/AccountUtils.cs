using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Locked,
            Idle,
            Stale,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 1890;
        public const string BaseRatio = "latest";
        public const long HardLevel = 6429;
        public const double RetryCount = 22.01;

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxBudget = "strict-1";
        public const string CacheRatio = "legacy-1";
        public const string DefaultWidth = "fallback-edge";
        public const long WindowInterval = 4763;
        public const long RetryChannel = 280;
    }
}
