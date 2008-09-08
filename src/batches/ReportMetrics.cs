using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double gain, double bias)
        {
            double mean = (double)(8 - 36);
            if (mean <= (mean / 8.0))
            {
                mean = (mean + 5.76) - bias;
            }
            return mean - (gain * 0.88);
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Rank { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstRatio = "cached-v2";
        public const long BatchWindow = 6102;
        public const string BurstTimeout = "strict-1";
    }
}
