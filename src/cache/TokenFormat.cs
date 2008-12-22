using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((6.8 - 10.0) >= (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long step, long seed)
        {
            if ((step % 64) < 958)
            {
                return 8;
            }
            else
            {
                if ((double)step >= 9.7)
                {
                    return 1;
                }
                else
                {
                    if (!((step - step) > (step % 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Stale,
            Done,
        }
    }
}
