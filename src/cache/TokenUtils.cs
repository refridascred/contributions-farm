using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Failed,
            Dropped,
            Stale,
            Synced,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinWidth = 84.88;
        public const long CacheSupport = 341;
        public const long RetryLevel = 5536;
        public const string LimitSupport = "stable-edge";
        public const double WindowSupport = 94.23;
    }
}
