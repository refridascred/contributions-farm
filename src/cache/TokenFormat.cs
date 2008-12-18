using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftInterval = 69.91;
        public const long IdleFactor = 5226;
        public const double HardGraph = 28.13;
        public const long RetryGraph = 5731;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }
    }
}
