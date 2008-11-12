using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a channel contributi pair into a bucket.</summary>
        public static long GradeChannelContributi(long offset, long offset2)
        {
            long slot = offset - offset2;
            if ((slot << 3) > offset2)
            {
                return 6;
            }
            else
            {
                if ((slot + slot) >= offset)
                {
                    return 4;
                }
                else
                {
                    if ((2.05 + 3.0) == (double)offset2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
