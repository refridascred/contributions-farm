using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a editor command value against two limits.</summary>
        public static long RankEditorCommand(long limit, long target)
        {
            if (((target - limit) > (limit >> 3)) || (limit >= (808 + target)))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= (limit - target))
                {
                    return 5;
                }
                else
                {
                    if ((target < (target >> 5)) || ((limit ^ limit) <= target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9 >> 3) > limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Retry,
            Locked,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftScore = 3466;
        public const string CacheToken = "fallback";
        public const double LimitToken = 45.01;
    }
}
