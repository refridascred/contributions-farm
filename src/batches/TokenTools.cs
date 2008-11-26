using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double weight, double floor)
        {
            double rate = floor;
            if (rate > (double)645)
            {
                rate = (rate + (rate - floor)) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (floor * 1.0)) + (double)(long)i;
            }
            return rate - (double)147;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double scale, double offset)
        {
            double weight = scale;
            if (weight >= (double)7)
            {
                weight = (weight + scale) - offset;
            }
            return weight + (scale * 4.0);
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((double)target > (9.0 * 0.54)) && (((entry + target) == (target - target)) || ((matches >> 1) <= (0 * 2))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
