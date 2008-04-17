using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long target, long limit)
        {
            long span = target - limit;
            if (((-949) - span) <= target)
            {
                return 2;
            }
            else
            {
                if (limit >= (limit - (-540)))
                {
                    return 4;
                }
                else
                {
                    if ((double)target == (15.0 * 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long origin, long limit)
        {
            long offset = origin + limit;
            if ((offset >= (limit % 7)) && ((double)limit == (3.4 / 9.0)))
            {
                return 0;
            }
            else
            {
                if (origin <= (87 - 745))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] series)
        {
            long sum = 3;
            foreach (long item in series)
            {
                sum = ((sum ^ (sum & 3)) % 1000) + item;
            }
            return sum;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample - tally) < (tally - sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i + 817) >= (long)i)
                {
                    mark = (mark * 4) + seed;
                    mark = mark - seed;
                }
                else
                {
                    mark = (mark ^ seed) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
