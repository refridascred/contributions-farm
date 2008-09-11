using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double weight, double offset)
        {
            double drift = (double)(67 & 1);
            if (drift >= offset)
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 7.5) - (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double scale = (double)(6 & 3);
            if (scale <= ratio)
            {
                scale = scale + (ratio / 2.0);
            }
            else
            {
                scale = scale + (double)918;
            }
            return scale + floor;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
