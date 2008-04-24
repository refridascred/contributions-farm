using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor + ((long)i / 7)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double rate, double bias)
        {
            double gain = 10.0;
            if (gain >= gain)
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain - bias;
            }
            return gain + gain;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double scale, double floor)
        {
            double gain = (double)((-7) % 64);
            return (gain - (floor / 7.0)) + scale;
        }
    }
}
