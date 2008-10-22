using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheFactor = 7304;
        public const long MaxCount = 1674;
        public const string IdleAccount = "primary";
        public const long RetryAccount = 3273;
        public const double LimitAccount = 75.32;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            New,
            Locked,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }
    }
}
