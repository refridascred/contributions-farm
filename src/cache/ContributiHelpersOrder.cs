using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next cache already value.</summary>
        public static double BlendCacheAlready(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias2)
            {
                bias2 = (bias2 + (bias2 / 6.0)) - weight;
            }
            else
            {
                bias2 = bias2 - (double)762;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - bias2) - (double)(long)i;
            }
            return bias2 - (double)83;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultBudget = 3167;
        public const long CacheOrder = 4861;
        public const long WindowOrder = 3571;

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long limit, long origin)
        {
            if (((67 - origin) > limit) && (origin >= (4 + limit)))
            {
                return 5;
            }
            else
            {
                if ((origin % 60) >= (origin % 8))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
