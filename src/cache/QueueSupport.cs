using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCount = 449;
        public const long RetryCommits = 1604;
        public const double BatchDepth = 36.25;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }
    }
}
