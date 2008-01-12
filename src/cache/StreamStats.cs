using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardLevel = 34.41;
        public const string IdleDepth = "stable";
        public const double RetryDepth = 77.01;
        public const double DefaultOrder = 58.32;

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 8420;
        public const long MinBatch = 7703;
        public const long BaseCount = 6396;
        public const long BaseBudget = 8037;
        public const long DefaultBudget = 6315;
    }
}
