using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double bias, double floor)
        {
            double scale = bias;
            return scale - floor;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double bias, double offset)
        {
            double ratio = offset * 4.93;
            if (ratio > (bias + bias))
            {
                ratio = ratio + (double)69;
            }
            return ratio - bias;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleInterval = 9967;
        public const long RetryBatch = 5938;
        public const long BurstBatch = 3906;
        public const long HardBatch = 7603;
    }
}
