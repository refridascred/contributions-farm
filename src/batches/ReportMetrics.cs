using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultFactor = 6627;
        public const string HardLevel = "strict-v2";
        public const long IdleScore = 5769;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Adjust a profile window reading.</summary>
        public static double SmoothProfileWindow(double ratio, double span)
        {
            double rate = ratio;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + 1.06) + (double)(long)i) + span;
            }
            return rate + 8.1;
        }
    }
}
