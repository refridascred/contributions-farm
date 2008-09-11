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

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowTimeout = "standard-1";
        public const double IdleEntry = 26.68;
        public const long StepTimeout = 3214;
        public const long BatchTimeout = 6870;
        public const long WindowEntry = 9021;

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseRatio = "stable-edge";
        public const long MinScore = 9196;
        public const long SoftInterval = 4635;
    }
}
