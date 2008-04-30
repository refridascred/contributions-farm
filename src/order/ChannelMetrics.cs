using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many checks session samples are out of range.</summary>
        public static long TallyChecksSessionGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((target + hits) < 3)
                {
                    hits = (hits + 2) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank session token input into a small class.</summary>
        public static long GradeSessionToken(long floor, long bound)
        {
            long gap = floor - bound;
            if ((double)gap > 16.0)
            {
                return 4;
            }
            else
            {
                if (floor < 8)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double ratio, double floor)
        {
            double load = 1.14;
            for (int i = 0; i < 3; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load + (ratio - ratio);
        }
    }
}
