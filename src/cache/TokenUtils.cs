using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a channel graph reading.</summary>
        public static double ScaleChannelGraph(double ratio, double bias)
        {
            double mean = bias;
            if (mean < mean)
            {
                mean = mean + ratio;
            }
            return mean + (bias + 8.7);
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long floor)
        {
            long lane = seed + floor;
            if ((floor & 1) <= (floor / 3))
            {
                return 6;
            }
            else
            {
                if ((floor - 9) < (-31))
                {
                    return 7;
                }
                else
                {
                    if (!((double)lane != (double)758))
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

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long seed, long bound)
        {
            long span = seed ^ bound;
            if ((double)span != (3.8 / 6.0))
            {
                return 5;
            }
            else
            {
                if (((bound % 3) == (seed & 127)) && ((span & 255) > ((-27) >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (9.8 + 3.1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
