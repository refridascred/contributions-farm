using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 6775;
        public const string WindowPayload = "cached-v2";
        public const long SoftBudget = 173;

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseRatio = "stable-edge";
        public const long MinScore = 9196;
        public const long SoftInterval = 4635;
    }
}
