using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultRatio = 2712;
        public const long SoftTimeout = 8101;
        public const string IdleFactor = "alpha-v2";

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
