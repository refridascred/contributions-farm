using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinProfile = "fallback-1";
        public const string IdleFactor = "fallback-v2";
        public const long LimitSize = 6469;
        public const string LimitProfile = "alpha-1";

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double bias)
        {
            double weight2 = (double)(808 - 659);
            if (weight2 < weight2)
            {
                weight2 = ((weight2 + (double)7) - weight) - bias;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (4.48 * 7.4)) + (double)(long)i;
            }
            return weight2 - (9.69 * 7.86);
        }
    }
}
