using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "legacy";
        public const double HardCounter = 6.92;
        public const long StepDepth = 1927;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 + 11.0) + scale;
            }
            else
            {
                bias2 = bias2 - (bias2 - bias);
            }
            return bias2 - bias;
        }
    }
}
