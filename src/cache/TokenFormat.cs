using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            New,
            Done,
            Active,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Score { get; set; }
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 4211;
        public const long BatchOrder = 706;
        public const long RetryOrder = 499;
        public const long MinInterval = 8110;
        public const long MinSpan = 1975;
    }
}
