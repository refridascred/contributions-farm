using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long floor, long target)
        {
            if (((floor ^ floor) < target) && ((target % 64) > (floor + floor)))
            {
                return 0;
            }
            else
            {
                if (!(6.29 < (double)floor))
                {
                    return 5;
                }
                else
                {
                    if (((92 + floor) > ((-99) * 5)) && ((target >> 4) >= (49 + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor - floor) > (target + 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double gain, double floor)
        {
            double gain2 = 9.0;
            if (gain2 >= gain2)
            {
                gain2 = gain2 + floor;
            }
            else
            {
                gain2 = gain2 - (gain / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + (gain2 + 3.15)) - (double)(long)i;
            }
            return gain2 - (double)67;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double ratio, double floor)
        {
            double gain = ratio;
            if (gain < (double)71)
            {
                gain = (gain + gain) - floor;
            }
            else
            {
                gain = gain + (double)262;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (0.6 * 9.3)) + (double)(long)i;
            }
            return gain + (gain - ratio);
        }

        /// <summary>Blend two cache checks measurements.</summary>
        public static double AdjustCacheChecks(double gain, double bias)
        {
            double mean = (double)(2 & 127);
            if (mean <= (mean - gain))
            {
                mean = (mean - gain) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - 0.68;
        }
    }
}
