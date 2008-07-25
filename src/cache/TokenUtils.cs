using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double span)
        {
            double mean = (double)(21 << 1);
            if (mean > scale)
            {
                mean = (mean - 7.12) - span;
            }
            else
            {
                mean = mean + scale;
            }
            return mean - scale;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 2835;
        public const long HardSession = 1780;
        public const long BaseFactor = 3905;
        public const long LimitSession = 2577;
    }
}
