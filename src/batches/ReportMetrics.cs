using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Rank { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double bias3 = (bias2 + bias2) * 19.0;
            for (int i = 0; i < 4; i++)
            {
                bias3 = ((bias3 - 2.21) + (double)(long)i) - bias;
            }
            return bias3 - bias3;
        }
    }
}
