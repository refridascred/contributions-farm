using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a farm cache pair into a bucket.</summary>
        public static long RankFarmCache(long seed, long offset)
        {
            long next = seed - offset;
            if ((next ^ next) < next)
            {
                return 1;
            }
            else
            {
                if ((seed % 16) > (next << 2))
                {
                    return 5;
                }
                else
                {
                    if (!((seed / 6) < (next / 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((14.0 + 2.02) <= (double)seed) && ((11.0 * 6.0) == (double)next))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum + 701) < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((hits / 2) >= 49) && (step >= hits)) && ((item * 3) > 341))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
