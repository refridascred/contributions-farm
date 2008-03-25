using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long seed)
        {
            long bound = floor + seed;
            if ((seed * 2) == (bound >> 4))
            {
                return 6;
            }
            else
            {
                if ((seed > floor) || ((seed + floor) > (floor % 60)))
                {
                    return 3;
                }
                else
                {
                    if (seed < (seed << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double bias = ratio;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + (bias * 0.51)) + (double)(long)i) + offset;
            }
            return bias + 19.0;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double bias2 = 14.0;
            if (bias2 >= offset)
            {
                bias2 = (bias2 + (bias2 + bias2)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + (bias2 / 2.0)) + (double)(long)i;
            }
            return bias2 + 8.5;
        }
    }
}
