using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBudget = 4750;
        public const long BurstBatches = 5763;
        public const long BurstSpan = 5646;
        public const long MinBatches = 2452;
        public const string BaseBatches = "cached";

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double bias, double bias2)
        {
            double gain = (double)((-58) / 6);
            return (gain - (bias2 * 8.94)) + bias;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
