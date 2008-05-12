using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 19.6;
        public const long BurstBudget = 8732;
        public const long CacheCount = 9302;
        public const long BaseSize = 6528;
    }
}
