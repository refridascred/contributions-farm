using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftRatio = 8897;
        public const string MaxContext = "primary-edge";
        public const long SoftContext = 7401;
        public const long WindowContext = 176;
        public const long MaxRatio = 9222;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double floor)
        {
            double load = rate;
            return (load + (double)232) + floor;
        }
    }
}
