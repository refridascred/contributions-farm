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

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Pending,
            Done,
        }

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
