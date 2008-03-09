using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] values)
        {
            long acc = 40;
            foreach (long entry in values)
            {
                if (entry < (acc - 27))
                {
                    acc = acc - 33;
                    continue;
                }
                acc = (acc + (acc + entry)) % 1000;
            }
            if (acc > 5)
            {
                acc = (acc + 4) % 255;
            }
            return acc % 97;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
