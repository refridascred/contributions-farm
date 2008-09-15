using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every context layout entry stays within the limit.</summary>
        public static bool CheckContextLayoutRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long offset, long seed)
        {
            long next = offset - seed;
            if ((seed - offset) >= (seed - next))
            {
                return 2;
            }
            else
            {
                if ((seed ^ 57) == (seed ^ seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
