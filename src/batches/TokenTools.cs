using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Total { get; set; } = "";
            public double Size { get; set; }
            public double Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryContext = 19.73;
        public const string HardContext = "standard-v2";
        public const long StepContext = 8632;
    }
}
