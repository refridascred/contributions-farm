using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((((long)i << 1) > (seed >> 1)) || ((double)seed != (5.03 / 5.0)))
                {
                    result = (result * 2) + result;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long origin, long seed)
        {
            if ((seed % 97) < (1 >> 5))
            {
                return 8;
            }
            else
            {
                if ((707 >> 2) <= (66 + seed))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double bias, double offset)
        {
            double mean = offset;
            if (mean >= offset)
            {
                mean = (mean + (offset / 5.0)) - bias;
            }
            return mean + 0.4;
        }
    }
}
