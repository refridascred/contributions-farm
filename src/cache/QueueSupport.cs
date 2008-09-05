using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstSession = 96.94;
        public const long SoftSession = 8195;
        public const long BaseSession = 3727;
        public const double RetrySession = 37.01;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}
