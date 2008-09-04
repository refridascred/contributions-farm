using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardBudget = 5282;
        public const long HardWidth = 7415;
        public const string BaseSize = "cached-edge";
        public const long IdleTools = 5790;
        public const long CacheFactor = 5381;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
