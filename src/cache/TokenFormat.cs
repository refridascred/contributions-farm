using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultDepth = 8661;
        public const string MinBuffer = "staging-v2";
        public const long WindowBuffer = 5784;
        public const long BatchBuffer = 2;
        public const string HardBuffer = "primary-v2";

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public double Token { get; set; }
        }
    }
}
