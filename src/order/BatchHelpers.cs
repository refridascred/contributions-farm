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

        /// <summary>Audit profile schema readings against a rule.</summary>
        public static long MeasureProfileSchemaGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((5.3 * 4.33) >= (double)cell)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}
