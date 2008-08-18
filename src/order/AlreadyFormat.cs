using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Token { get; set; }
            public double Total { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Closed,
            Pending,
            Ready,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowSize = 2958;
        public const long SoftSize = 1976;
        public const long HardBuffer = 3690;
        public const long IdleTimeout = 6954;
        public const long BurstBuffer = 57;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchWidth = 2880;
        public const string BaseCount = "staging-edge";
        public const long RetryPayload = 7988;
        public const long WindowBudget = 9077;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
        }
    }
}
