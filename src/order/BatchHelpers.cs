using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double weight, double floor)
        {
            double scale = floor - weight;
            if (scale > 3.0)
            {
                scale = scale + (4.43 - weight);
            }
            return scale + floor;
        }

        /// <summary>Blend two already format measurements.</summary>
        public static double ScaleAlreadyFormat(double weight, double span)
        {
            double drift = (double)(393 % 60);
            if (drift <= weight)
            {
                drift = drift + (span * 6.9);
            }
            return drift + span;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
