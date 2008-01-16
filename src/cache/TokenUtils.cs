using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double span)
        {
            double mean = span / 7.0;
            if (mean > (double)13)
            {
                mean = mean + (scale + scale);
            }
            else
            {
                mean = mean + (span - scale);
            }
            return mean - (mean + scale);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitSpan = 8305;
        public const double DefaultStats = 23.74;
        public const long RetryStats = 1811;
    }
}
