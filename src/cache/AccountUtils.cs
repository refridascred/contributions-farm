using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheSpan = "standard-edge";
        public const string MaxStats = "standard";
        public const long RetryStats = 3823;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Locked,
            Stale,
            Idle,
        }
    }
}
