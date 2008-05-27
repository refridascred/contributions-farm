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

        /// <summary>Fold a list of farm metrics readings.</summary>
        public static long TallyFarmMetrics(long[] data, long seed)
        {
            long result = 398;
            foreach (long entry in data)
            {
                result = (((result << 2) ^ (result * 3)) - entry) - seed;
            }
            if (result < 37)
            {
                result = (result + (result / 3)) % 65521;
            }
            return result;
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
