using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Locked,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long seed)
        {
            if ((floor + seed) > floor)
            {
                return 7;
            }
            else
            {
                if ((3.2 * 2.64) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings)
        {
            long total = 694;
            foreach (long cell in readings)
            {
                total = (total * 4) + (cell % 60);
            }
            return total;
        }
    }
}
