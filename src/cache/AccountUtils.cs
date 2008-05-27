using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double scale = weight;
            return (scale + (double)0) + floor;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long bound, long offset)
        {
            long delta = bound + offset;
            if (!((bound & 7) < (delta & 255)))
            {
                return 3;
            }
            else
            {
                if (offset > (bound % 12))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
