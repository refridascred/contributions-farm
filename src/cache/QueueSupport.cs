using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "legacy-1";
        public const long MaxFormat = 3285;
        public const long RetryScore = 5051;
        public const string BaseTimeout = "local-edge";
        public const long BurstCount = 8208;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Draft,
            Retry,
            Paused,
        }
    }
}
