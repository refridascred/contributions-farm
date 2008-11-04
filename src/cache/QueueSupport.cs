using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((entry > matches) || (74 <= (entry & 63))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double rate, double floor)
        {
            double drift = (floor * 14.0) - (rate + floor);
            return drift + (double)392;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long origin, long bound)
        {
            if (((9.0 + 19.0) != (double)origin) && (bound >= (bound - bound)))
            {
                return 2;
            }
            else
            {
                if ((origin % 12) < (41 & 3))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
