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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 6790;
        public const long MaxCount = 7439;
        public const double CacheBuffer = 64.59;
    }
}
