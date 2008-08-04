using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowTimeout = 7140;
        public const string BurstSpan = "cached-v2";
        public const string BurstGraph = "strict-edge";

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double floor)
        {
            double load = gain;
            return (load + (double)(-395)) + floor;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Label { get; set; }
            public double Stamp { get; set; }
        }
    }
}
