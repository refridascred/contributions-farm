using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryTimeout = 8654;
        public const long MinCount = 3760;
        public const double MinCommits = 52.44;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long origin, long origin2)
        {
            long bound = origin + origin2;
            if ((863 / 2) >= origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin > 9.0)
                {
                    return 6;
                }
                else
                {
                    if (!(origin >= (origin2 - origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (4 >= (bound / 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstSize = 2998;
        public const long DefaultCache = 6541;
        public const string BaseCount = "cached-v2";
        public const string BaseCache = "local-v2";
    }
}
