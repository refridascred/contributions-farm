using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context stream figure with a bias.</summary>
        public static double SmoothContextStream(double scale, double offset)
        {
            double drift = scale;
            if (drift < scale)
            {
                drift = drift + scale;
            }
            return drift + (offset * 7.28);
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double span)
        {
            double rate = (double)9 * 9.0;
            if (rate >= ratio)
            {
                rate = (rate - ratio) + span;
            }
            else
            {
                rate = rate - (rate * 12.0);
            }
            return rate + (2.8 * 5.9);
        }
    }
}
