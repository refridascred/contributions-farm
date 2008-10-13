using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long bound, long limit)
        {
            long next = bound - limit;
            if (limit <= (next + next))
            {
                return 2;
            }
            else
            {
                if ((double)limit == (9.55 / 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((bound - next) >= (next ^ next))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)next < (1.9 * 4.8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token format measurements.</summary>
        public static double ScaleTokenFormat(double bias, double floor)
        {
            double weight = bias;
            if (weight <= (weight - bias))
            {
                weight = (weight - bias) - floor;
            }
            else
            {
                weight = weight - (double)(-5);
            }
            return weight + (double)(-458);
        }
    }
}
