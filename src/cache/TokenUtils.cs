using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long seed, long origin)
        {
            long delta = seed - origin;
            if (!((390 + origin) < (seed - delta)))
            {
                return 8;
            }
            else
            {
                if (1.5 < (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Done,
            Locked,
            Stale,
            Draft,
        }
    }
}
