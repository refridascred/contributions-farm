using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 8166;
        public const double BurstSpan = 82.43;
        public const long StepTimeout = 6694;
        public const string HardTools = "strict-v2";

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            Done,
            New,
            Locked,
            Queued,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double weight, double bias)
        {
            double scale = (double)(570 + 288);
            if (scale < weight)
            {
                scale = scale - scale;
            }
            return scale - bias;
        }
    }
}
