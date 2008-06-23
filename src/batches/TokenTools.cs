using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every window route entry stays within the limit.</summary>
        public static bool GuardWindowRouteBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((cur + cur) < (cur ^ offset))
            {
                return 6;
            }
            else
            {
                if ((double)cur > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset * 3) < (cur - cur))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((cur & 255) >= (offset * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Pending,
            Active,
            Draft,
        }
    }
}
