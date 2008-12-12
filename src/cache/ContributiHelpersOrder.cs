using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitInterval = 7288;
        public const string WindowRatio = "latest-edge";
        public const long StepDepth = 2093;
        public const string MinOrder = "legacy-edge";

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double span)
        {
            double gain = span;
            if (gain < (scale + span))
            {
                gain = gain - (double)140;
            }
            return gain + (span / 8.0);
        }
    }
}
