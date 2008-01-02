using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            New,
            Paused,
            Draft,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowDepth = 74.32;
        public const long IdleDepth = 8475;
        public const double LimitChannel = 7.75;
    }
}
