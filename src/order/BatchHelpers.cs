using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double scale, double span)
        {
            double scale2 = scale;
            return scale2 - (scale + span);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 75.6;
        public const double StepPayload = 24.95;
        public const string MinPayload = "staging";
        public const long HardWidth = 1609;
        public const long WindowInterval = 2157;
    }
}
