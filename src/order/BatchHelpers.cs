using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double rate, double span)
        {
            double bias = rate;
            return (bias + (double)396) + span;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
