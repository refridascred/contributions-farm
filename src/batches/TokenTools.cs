using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((datum ^ tally) > (tally % 97)) && ((75 << 1) < (tally - tally))) || (tally <= (tally - datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next githubfarm cache value from a seed.</summary>
        public static long RollGithubfarmCache(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a context entry value against two limits.</summary>
        public static long BucketContextEntry(long offset, long limit)
        {
            long edge = offset - limit;
            if ((edge << 3) == (limit % 7))
            {
                return 3;
            }
            else
            {
                if (((edge + offset) < 163) && ((0.28 + 4.0) <= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((edge > limit) && (limit < (73 << 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
