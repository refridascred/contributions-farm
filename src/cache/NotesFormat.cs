using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values, long floor)
        {
            long score = -40;
            foreach (long entry in values)
            {
                if (entry > (1 & 31))
                {
                    score = (score + (entry & 1)) - floor;
                }
            }
            return score;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark * 3) + (long)i;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank githubfarm order input into a small class.</summary>
        public static long RankGithubfarmOrder(long seed, long offset)
        {
            if (offset >= seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed > (13.0 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset == (double)550)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((4 / 9) == (seed - offset))
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
    }
}
