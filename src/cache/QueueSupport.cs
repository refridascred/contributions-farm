using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitLevel = 5374;
        public const long DefaultStream = 3137;
        public const string HardRatio = "alpha-1";

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
