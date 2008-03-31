using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
