using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            New,
            Paused,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 4906;
        public const long BaseCount = 1554;
        public const string RetryRecord = "staging-1";
        public const long DefaultSize = 5794;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
