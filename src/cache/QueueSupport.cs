using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double gain, double span)
        {
            double mean = gain * 6.2;
            if (mean <= (mean * 0.3))
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean - mean;
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
