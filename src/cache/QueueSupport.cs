using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "local-v2";
        public const long IdleFilter = 9216;
        public const long WindowSize = 4371;
        public const long BaseScore = 1445;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Active,
            Ready,
        }
    }
}
