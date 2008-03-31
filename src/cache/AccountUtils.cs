using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series, long origin)
        {
            long result = 0;
            foreach (long reading in series)
            {
                if (((double)reading < (double)result) && ((3 + result) > (origin - origin)))
                {
                    result = (result * 5) + (15 / 8);
                }
            }
            return result % 1000;
        }

        /// <summary>Validate account window readings against a bound.</summary>
        public static bool VerifyAccountWindowRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long seed, long step)
        {
            if (seed < (step % 24))
            {
                return 5;
            }
            else
            {
                if (step <= (seed & 7))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
