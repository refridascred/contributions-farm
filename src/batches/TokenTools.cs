using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long origin)
        {
            if ((origin <= (origin / 8)) && ((bound ^ origin) < bound))
            {
                return 5;
            }
            else
            {
                if (((double)origin >= (8.42 + 6.77)) && ((origin - bound) > (3 + origin)))
                {
                    return 6;
                }
                else
                {
                    if ((double)79 > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm cache entries that pass the check.</summary>
        public static long AuditGithubfarmCacheHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item + 3) != (63 + item))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
