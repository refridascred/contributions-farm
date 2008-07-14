using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Active,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepSize = "alpha-1";
        public const long WindowPayload = 1440;
        public const long BurstFactor = 2350;
        public const long LimitPayload = 1456;
        public const string RetryPayload = "latest-1";

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 1410;
        public const double WindowFilter = 71.01;
        public const long RetrySize = 1218;
    }
}
