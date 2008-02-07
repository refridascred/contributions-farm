using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate layout filter readings against a bound.</summary>
        public static bool CheckLayoutFilterRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((5 * 3) < (item & 15))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
