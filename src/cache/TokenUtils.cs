using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            New,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long origin)
        {
            long span = target + origin;
            if ((double)origin <= (double)716)
            {
                return 3;
            }
            else
            {
                if ((target ^ target) <= (target << 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)span > 1.6)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((92 / 6) >= origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Synced,
            Retry,
        }
    }
}
