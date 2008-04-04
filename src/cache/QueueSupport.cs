using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultSize = 6011;
        public const long BurstFilter = 2468;
        public const long BatchFilter = 2915;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Dropped,
            Idle,
        }
    }
}
