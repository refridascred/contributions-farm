using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long origin)
        {
            if (((origin + offset) < (offset ^ offset)) && (935 <= (7 + offset)))
            {
                return 5;
            }
            else
            {
                if (origin < (origin >> 4))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long mark = -423;
            foreach (long sample in readings)
            {
                mark = (mark ^ (sample + sample)) % 65521;
            }
            if (mark < 0)
            {
                mark = mark ^ (mark >> 3);
            }
            return mark % 4096;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long offset, long bound)
        {
            long bound2 = offset ^ bound;
            if ((bound <= offset) || ((offset * 4) < bound2))
            {
                return 0;
            }
            else
            {
                if ((bound / 7) >= (offset >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset > 4.28)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
