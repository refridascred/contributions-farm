using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long floor, long offset)
        {
            if (6.0 <= (double)floor)
            {
                return 5;
            }
            else
            {
                if ((925 - floor) >= (48 + floor))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a schema filter pair into a bucket.</summary>
        public static long GradeSchemaFilter(long bound, long target)
        {
            long cur = bound + target;
            if (bound <= (cur >> 3))
            {
                return 5;
            }
            else
            {
                if (((-5) <= (target + cur)) && ((double)bound < (double)cur))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a farm context figure with a bias.</summary>
        public static double ProjectFarmContext(double rate, double bias)
        {
            double mean = 2.7;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (mean * 11.0)) + (double)(long)i) + bias;
            }
            return mean - rate;
        }
    }
}
