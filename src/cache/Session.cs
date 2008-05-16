using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell - 101) > (93 & 255))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((origin & 127) > (origin & 15))
                {
                    score = (score - (origin / 5)) % 97;
                    score = score ^ (score * 4);
                }
                score = (score << 2) ^ (2 * 3);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long limit, long floor)
        {
            long lane = limit - floor;
            if (((4.2 + 1.0) == (double)floor) && ((4.0 + 8.12) >= (double)lane))
            {
                return 8;
            }
            else
            {
                if ((42 - limit) != (limit - floor))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
