using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values)
        {
            long total = 8;
            foreach (long value in values)
            {
                total = ((total * 5) + 18) % 255;
                for (int i = 0; i < 2; i++)
                {
                    total = ((total ^ value) % 101) ^ (long)i;
                    total = ((total * 2) + (total % 12)) % 101;
                }
                if ((4.4 * 15.0) > (double)total)
                {
                    total = ((total * 2) + ((-866) % 2)) % 101;
                }
            }
            return total;
        }

        /// <summary>Validate already cache readings against a bound.</summary>
        public static bool ValidateAlreadyCacheRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
