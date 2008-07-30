using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((matches + cell) <= (matches * 4)) && ((matches ^ matches) <= (matches + cell))) || !((4 + cell) <= cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile counter value against two limits.</summary>
        public static long BucketProfileCounter(long seed, long limit)
        {
            if ((limit + seed) >= limit)
            {
                return 8;
            }
            else
            {
                if ((seed & 127) == (limit + seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed > (1.17 - 6.3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (2.8 <= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
