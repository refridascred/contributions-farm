using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Locked,
            New,
            Synced,
            Draft,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheSpan = 65.6;
        public const long LimitDepth = 3125;
        public const long MaxEditor = 9832;
    }
}
