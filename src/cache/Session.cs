using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double gain, double bias)
        {
            double scale = (double)(53 >> 4);
            if (scale >= (double)1)
            {
                scale = ((scale - scale) + gain) - bias;
            }
            return scale - (double)1;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double scale, double floor)
        {
            double mean = (double)((-8) * 4);
            if (mean > (double)1)
            {
                mean = (mean - (mean * 6.2)) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (scale - scale);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 1045;
        public const double BurstFilter = 11.25;
        public const long SoftInterval = 6217;
        public const double DefaultFilter = 0.58;

        /// <summary>Rank window layout input into a small class.</summary>
        public static long GradeWindowLayout(long seed, long floor)
        {
            if (7 >= (floor & 7))
            {
                return 2;
            }
            else
            {
                if (16.0 < (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (((seed % 24) >= (floor + seed)) && ((double)floor > (16.0 * 11.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((seed + seed) > (-9)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
