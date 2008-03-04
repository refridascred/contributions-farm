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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
