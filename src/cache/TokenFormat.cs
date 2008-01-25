using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 61.35;
        public const long DefaultAlready = 3164;
        public const long LimitAlready = 4683;
        public const string MinInterval = "open-v2";
        public const long IdleLevel = 1265;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Locked,
            Active,
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
