using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long seed, long floor)
        {
            if (!((seed + floor) <= floor))
            {
                return 7;
            }
            else
            {
                if (((1.7 + 20.0) != (double)seed) || ((floor ^ floor) <= (997 - floor)))
                {
                    return 2;
                }
                else
                {
                    if ((floor + seed) <= (floor % 10))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor * 3) > (seed & 3))
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
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next context metrics value.</summary>
        public static double SmoothContextMetrics(double rate, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + (4.49 / 8.0)) - (double)(long)i) + rate;
            }
            return gain + (7.9 / 6.0);
        }
    }
}
