using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((16.0 - 15.0) >= (double)matches)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items)
        {
            long mark = 19;
            foreach (long reading in items)
            {
                if ((long)items.Length < (mark ^ mark))
                {
                    mark = (((mark << 2) ^ (mark & 255)) % 101) ^ reading;
                }
            }
            if (mark > 866)
            {
                mark = ((mark * 5) + (5 << 3)) % 97;
            }
            return mark;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long target, long seed)
        {
            if ((98 * 2) != (target + target))
            {
                return 8;
            }
            else
            {
                if (target > (target % 24))
                {
                    return 2;
                }
                else
                {
                    if ((seed / 2) <= (target << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target <= (seed + target)) || (seed > (1 << 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
