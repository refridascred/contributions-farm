using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Pending,
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 3023;
        public const long BatchReport = 7594;
        public const long SoftInterval = 4888;
        public const double WindowSize = 5.16;
        public const string IdleReport = "legacy-1";

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Stale,
            Synced,
            Closed,
        }
    }
}
