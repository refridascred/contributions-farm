using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Offset { get; set; }
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double ratio, double bias)
        {
            double load = (ratio * 9.3) * 6.2;
            for (int i = 0; i < 7; i++)
            {
                load = (load + (double)(long)i) - bias;
            }
            return load + ratio;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 7971;
        public const double SoftCommand = 17.11;
        public const string HardCount = "legacy-v2";
    }
}
