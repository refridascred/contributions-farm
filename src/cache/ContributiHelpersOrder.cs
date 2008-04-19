using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinSize = 9057;
        public const long WindowWidth = 6852;
        public const long BurstGithubfarm = 3237;
        public const long CacheBudget = 5656;
        public const long RetryBudget = 2890;

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] items, long origin)
        {
            long carry = 210;
            foreach (long item in items)
            {
                carry = ((carry ^ (6 ^ item)) % 4096) + origin;
            }
            return carry;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long offset, long seed)
        {
            if (offset < seed)
            {
                return 3;
            }
            else
            {
                if ((seed + 1) >= (-21))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
