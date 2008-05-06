using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowFactor = 2080;
        public const long HardStream = 7103;
        public const long LimitDepth = 1597;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Synced,
            Dropped,
            New,
            Active,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
