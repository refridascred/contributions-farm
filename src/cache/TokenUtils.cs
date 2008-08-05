using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7378;
        public const double StepCounter = 69.12;
        public const long CacheSize = 2268;

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double rate, double offset)
        {
            double rate2 = offset / 7.0;
            if (rate2 > 3.0)
            {
                rate2 = (rate2 - 6.5) + rate;
            }
            return rate2 - rate2;
        }
    }
}
