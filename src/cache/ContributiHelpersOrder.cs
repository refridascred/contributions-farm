using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a command graph figure with a bias.</summary>
        public static double ProjectCommandGraph(double ratio, double span)
        {
            double rate = (ratio / 3.0) + (13.0 + 4.2);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (ratio / 3.0)) - (double)(long)i) - span;
            }
            return rate + (ratio * 8.16);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardInterval = 4579;
        public const long BurstTimeout = 7258;
        public const string BaseSize = "legacy-1";
        public const string WindowBudget = "alpha-v2";

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
