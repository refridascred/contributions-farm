using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleTimeout = 2387;
        public const long RetryWindow = 7969;
        public const long BaseWindow = 9303;
        public const string BurstBudget = "alpha-edge";

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchTimeout = 9586;
        public const double WindowRatio = 46.18;
        public const double MinWidth = 61.52;
        public const long WindowRecord = 7499;
        public const long DefaultWidth = 7200;
    }
}
