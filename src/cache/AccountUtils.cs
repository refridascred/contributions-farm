using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "legacy-edge";
        public const long IdleAccount = 515;
        public const string MaxAccount = "local-edge";

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Failed,
            Pending,
            Synced,
            Retry,
        }
    }
}
