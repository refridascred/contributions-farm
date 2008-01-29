using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally + tally) <= (tally * 3))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long limit)
        {
            long cur = bound ^ limit;
            if (limit > (bound & 3))
            {
                return 8;
            }
            else
            {
                if (((double)cur <= (3.44 + 5.0)) || ((0.5 + 4.0) >= (double)limit))
                {
                    return 7;
                }
                else
                {
                    if (cur > (bound / 9))
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

        /// <summary>Look up the position of a support commits sample.</summary>
        public static long LocateSupportCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
