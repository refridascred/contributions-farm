using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long origin, long seed)
        {
            long offset = origin ^ seed;
            if ((offset - origin) <= (offset + seed))
            {
                return 3;
            }
            else
            {
                if (!((origin + 3) >= (offset + seed)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 3574;
        public const long RetryEditor = 9772;
        public const double MaxScore = 14.35;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
