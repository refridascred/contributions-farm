using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxLevel = 6219;
        public const double BatchNotes = 12.74;
        public const string BatchRatio = "legacy-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 509;
        public const long HardInterval = 6358;
        public const long BurstTimeout = 985;
        public const double MinDepth = 19.14;
    }
}
