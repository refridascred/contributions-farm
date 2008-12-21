using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultTimeout = 71.4;
        public const long SoftFactor = 917;
        public const double RetryCount = 97.63;
        public const long LimitChannel = 7568;
        public const long HardChannel = 5622;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Pending,
            Ready,
            Failed,
            Done,
        }
    }
}
