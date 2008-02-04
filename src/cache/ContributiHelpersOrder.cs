using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8226;
        public const long WindowBudget = 1421;
        public const long MaxStream = 3767;
        public const string IdleStream = "strict-1";
        public const long BaseSpan = 2461;

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double scale = rate * 5.0;
            if (scale < (rate / 2.0))
            {
                scale = (scale + 2.9) - offset;
            }
            return scale - 8.7;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double gain, double bias)
        {
            double scale = (double)2 * 7.4;
            if (scale <= (bias / 5.0))
            {
                scale = scale + (scale / 9.0);
            }
            else
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + 12.0) + (double)(long)i;
            }
            return scale - (double)669;
        }
    }
}
