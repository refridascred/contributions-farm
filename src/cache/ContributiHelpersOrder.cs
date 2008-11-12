using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double ratio = scale;
            if (ratio <= 4.4)
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - scale;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double bias, double span)
        {
            double ratio = bias;
            if (ratio <= (0.34 * 9.7))
            {
                ratio = (ratio + 7.69) + span;
            }
            else
            {
                ratio = ratio + (bias - bias);
            }
            return ratio - (bias - 4.3);
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
