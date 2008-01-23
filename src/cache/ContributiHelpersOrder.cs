using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix - bound) % 65521;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Ready,
            Active,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double bias, double floor)
        {
            double scale = floor;
            if (scale <= (bias / 9.0))
            {
                scale = scale - (floor + 6.6);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + (scale / 7.0);
        }
    }
}
