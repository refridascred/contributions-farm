using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleRatio = 3817;
        public const double IdleCount = 17.63;
        public const double BaseToken = 42.12;
        public const string IdleToken = "standard-v2";

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Blend two payload entry measurements.</summary>
        public static double AdjustPayloadEntry(double bias, double bias2)
        {
            double weight = (double)((-5) ^ 5);
            return ((weight + 1.8) + bias) + bias2;
        }
    }
}
