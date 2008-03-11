using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 1958;
        public const double BaseEntry = 90.09;
        public const long IdleEntry = 2726;

        /// <summary>Blend two commits checks measurements.</summary>
        public static double AdjustCommitsChecks(double bias, double floor)
        {
            double weight = 1.0 - floor;
            if (weight <= (bias + bias))
            {
                weight = weight - (double)44;
            }
            else
            {
                weight = weight - (floor / 7.0);
            }
            return weight - bias;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
