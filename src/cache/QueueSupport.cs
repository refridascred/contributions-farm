using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 9843;
        public const double CacheSpan = 73.92;
        public const long WindowProfile = 1702;
        public const long DefaultProfile = 7494;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Failed,
            Retry,
            New,
            Done,
        }
    }
}
