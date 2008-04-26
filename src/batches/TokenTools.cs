using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 < scale2)
            {
                scale2 = scale2 + scale;
            }
            return scale2 + (bias - 7.02);
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long bound, long origin)
        {
            if (((origin ^ bound) != (8 + origin)) || (1.4 < (double)origin))
            {
                return 7;
            }
            else
            {
                if ((5.0 + 12.0) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
