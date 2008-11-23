using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftFactor = "standard-1";
        public const long MaxSpan = 9764;
        public const long IdleLevel = 9552;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}
