using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string WindowFactor = "cached-edge";
        public const string MaxCount = "primary-v2";
        public const string DefaultAccount = "legacy-1";
        public const string BurstLevel = "standard";
        public const long BatchSize = 7377;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
