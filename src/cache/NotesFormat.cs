using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitCount = 1801;
        public const long DefaultAlready = 7596;
        public const long MaxAlready = 1479;
        public const string SoftAlready = "latest-edge";
        public const long HardBudget = 6004;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Pending,
            Retry,
            Locked,
        }
    }
}
