using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Stale,
            Done,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long bound, long step)
        {
            if ((step + step) <= (step * 2))
            {
                return 1;
            }
            else
            {
                if (((71 & 255) == (bound + (-780))) && ((42 - bound) < (bound - bound)))
                {
                    return 3;
                }
                else
                {
                    if (!(((-48) * 5) >= bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 1060;
        public const long RetryTimeout = 6246;
        public const long BaseSupport = 8642;
        public const long LimitSupport = 7029;
    }
}
