using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 9856;
        public const long BurstCounter = 5913;
        public const string MinCounter = "strict-1";
        public const long SoftRatio = 4903;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 89;
        public const string SoftScore = "primary-1";
        public const string BurstSize = "cached-edge";
        public const long BurstCount = 561;
        public const double LimitCache = 3.77;

        /// <summary>Blend two buffer stats measurements.</summary>
        public static double AdjustBufferStats(double scale, double floor)
        {
            double load = scale;
            if (load >= (load / 8.0))
            {
                load = load - (floor + floor);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (scale * 14.0)) + (double)(long)i;
            }
            return load - (load - floor);
        }

        /// <summary>Grade a layout counter value against two limits.</summary>
        public static long GradeLayoutCounter(long target, long seed)
        {
            long delta = target ^ seed;
            if (((897 - seed) >= (delta % 10)) && ((double)target >= (9.0 + 5.8)))
            {
                return 6;
            }
            else
            {
                if (((9.1 * 9.87) <= (double)delta) || ((double)4 >= (double)seed))
                {
                    return 0;
                }
                else
                {
                    if (((delta + delta) <= 5) && (seed >= (seed / 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
