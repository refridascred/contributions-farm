using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long origin, long origin2)
        {
            if ((origin2 - origin2) <= (origin2 >> 4))
            {
                return 8;
            }
            else
            {
                if ((4.1 - 9.0) >= (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin <= 7.0)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long seed)
        {
            long prev = offset - seed;
            if ((prev << 2) >= offset)
            {
                return 0;
            }
            else
            {
                if (prev <= (offset + seed))
                {
                    return 1;
                }
                else
                {
                    if (!((double)offset < (11.0 / 8.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] levels)
        {
            long score = 56;
            foreach (long entry in levels)
            {
                score = (score - (score & 7)) % 101;
                if ((double)score < (1.0 * 1.52))
                {
                    score = (score ^ entry) % 255;
                }
                if ((double)entry == (20.0 / 4.0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 + (double)734) + (double)(long)i) + span;
            }
            return ratio2 - (double)76;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
