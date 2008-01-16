using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepSpan = "stable";
        public const string WindowSession = "stable-edge";
        public const long IdleTimeout = 4475;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Idle,
            Active,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
