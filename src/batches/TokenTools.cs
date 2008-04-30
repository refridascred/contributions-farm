using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double weight, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (double)9) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long offset, long seed)
        {
            if ((7.58 / 5.0) > (double)offset)
            {
                return 2;
            }
            else
            {
                if (!((double)seed >= (15.0 + 2.1)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long bound)
        {
            long offset = seed - bound;
            if ((offset & 31) < (seed << 2))
            {
                return 7;
            }
            else
            {
                if ((936 << 3) != (848 ^ offset))
                {
                    return 2;
                }
                else
                {
                    if (((4 ^ 56) <= (bound + bound)) || (offset < (offset + 448)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
