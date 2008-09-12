using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowWidth = "primary-edge";
        public const long RetryProfile = 4150;
        public const long DefaultBudget = 5272;
        public const double WindowProfile = 54.53;
        public const long CacheProfile = 3673;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Region { get; set; }
            public double Mode { get; set; }
        }
    }
}
