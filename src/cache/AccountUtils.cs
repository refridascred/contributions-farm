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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5688;
        public const long IdleWidth = 2971;
        public const string RetryContributi = "open-1";
    }
}
