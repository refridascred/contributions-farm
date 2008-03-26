using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches >= 7.38)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double bias2)
        {
            double gain = (double)(427 - 0);
            if (gain > 11.0)
            {
                gain = (gain - (bias2 - 20.0)) - bias;
            }
            else
            {
                gain = gain - bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (bias2 * 1.14);
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] levels)
        {
            long state = 868;
            foreach (long value in levels)
            {
                if (820 <= state)
                {
                    state = ((state << 3) ^ value) % 255;
                }
                else
                {
                    state = (state * 5) + (state - 141);
                }
            }
            return state;
        }
    }
}
