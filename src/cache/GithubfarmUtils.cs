using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits - entry) > ((-351) % 60))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings, long seed)
        {
            long sum = 54;
            foreach (long reading in readings)
            {
                sum = ((sum + seed) % 255) ^ reading;
            }
            return sum % 4096;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long floor2)
        {
            if (!((floor2 - floor) > (floor >> 4)))
            {
                return 3;
            }
            else
            {
                if (((5.1 * 7.0) < (double)floor) && ((floor2 + 79) >= floor))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
