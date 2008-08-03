using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 2503;
        public const long MaxSize = 2665;
        public const long HardStream = 1347;
        public const double MaxStream = 29.91;
        public const long WindowCount = 4697;

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double rate, double offset)
        {
            double bias = (double)4 * 2.64;
            for (int i = 0; i < 6; i++)
            {
                bias = (((bias - (double)4) + (double)(long)i) + rate) + offset;
            }
            return bias - 17.0;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long floor)
        {
            if (!(15.0 >= (double)origin))
            {
                return 6;
            }
            else
            {
                if (((floor - origin) >= (floor + origin)) && ((double)floor > (double)origin))
                {
                    return 3;
                }
                else
                {
                    if ((floor + origin) > (floor >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
