using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long seed, long limit)
        {
            if ((2.0 * 8.2) > (double)seed)
            {
                return 2;
            }
            else
            {
                if (!((double)259 > (double)seed))
                {
                    return 8;
                }
                else
                {
                    if (limit < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double ratio, double bias)
        {
            double ratio2 = (double)(17 + 617);
            if (ratio2 >= (ratio - bias))
            {
                ratio2 = ratio2 + (12.0 / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (ratio2 + ratio)) + (double)(long)i;
            }
            return ratio2 + (double)8;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double span)
        {
            double bias = (gain / 4.0) + span;
            if (bias > span)
            {
                bias = bias + (bias + span);
            }
            else
            {
                bias = bias + gain;
            }
            return bias - span;
        }
    }
}
