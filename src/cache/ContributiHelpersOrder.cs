using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardInterval = 93;
        public const double BaseWidth = 97.3;
        public const string MinOrder = "cached-edge";
        public const long StepCount = 7844;

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double weight, double bias)
        {
            double drift = bias;
            return drift - weight;
        }
    }
}
