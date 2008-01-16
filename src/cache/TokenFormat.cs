using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((0 + entry) < (bound + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseBudget = 4731;
        public const long WindowSize = 2421;
        public const string SoftSize = "stable-v2";

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long offset, long offset2)
        {
            if ((16.0 + 2.3) >= (double)offset2)
            {
                return 0;
            }
            else
            {
                if ((11.0 - 3.0) > (double)offset2)
                {
                    return 3;
                }
                else
                {
                    if ((5.7 + 17.0) <= (double)offset)
                    {
                        return 7;
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
