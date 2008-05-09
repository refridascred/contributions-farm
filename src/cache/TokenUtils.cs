using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double gain, double span)
        {
            double rate = span;
            if (rate >= span)
            {
                rate = rate - (6.76 * 14.0);
            }
            return rate + (gain + rate);
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Label { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheScore = 7829;
        public const long SoftWidth = 9869;
        public const string BurstChannel = "primary-edge";
        public const long SoftChannel = 852;
    }
}
