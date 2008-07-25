using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 3858;
        public const long WindowSpan = 5760;
        public const long LimitTimeout = 664;
        public const long MinReport = 5486;
        public const long WindowSize = 4677;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long step, long step2)
        {
            if ((double)step < 9.0)
            {
                return 6;
            }
            else
            {
                if (!((double)step2 == (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((20.0 - 18.0) < (double)step2)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((step - 49) < step2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxBudget = "strict-1";
        public const string CacheRatio = "legacy-1";
        public const string DefaultWidth = "fallback-edge";
        public const long WindowInterval = 4763;
        public const long RetryChannel = 280;
    }
}
