using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 76.99;
        public const long WindowScore = 5836;
        public const string DefaultStream = "alpha";

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long bound, long target)
        {
            if ((16.0 + 20.0) < (4.9 + 20.0))
            {
                return 7;
            }
            else
            {
                if (((double)bound != (1.5 - 4.0)) || ((97 / 5) <= (bound + bound)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
