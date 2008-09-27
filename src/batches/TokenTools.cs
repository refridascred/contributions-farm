using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up metrics buffer samples.</summary>
        public static long CompareMetricsBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long bound)
        {
            long bound2 = seed ^ bound;
            if ((double)bound <= 0.52)
            {
                return 1;
            }
            else
            {
                if ((seed + 232) > (seed << 1))
                {
                    return 8;
                }
                else
                {
                    if (((bound >> 4) <= seed) || ((seed << 1) <= (seed - bound2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit cluster route readings against a rule.</summary>
        public static long TallyClusterRouteOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(hits <= (hits + 3)))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }
    }
}
