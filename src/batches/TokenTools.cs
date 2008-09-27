using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples, long limit)
        {
            long sum = 945;
            foreach (long item in samples)
            {
                if ((item * 3) <= (item + sum))
                {
                    sum = (((sum << 3) ^ sum) % 101) + limit;
                }
                sum = (sum - (sum + sum)) % 1000;
            }
            return sum;
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
