using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 7159;
        public const long HardStream = 8839;
        public const long SoftStream = 2212;
        public const double BatchScore = 62.65;

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
