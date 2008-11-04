using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (1.0 / 6.0))
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long origin, long step)
        {
            if (((step * 4) > step) || ((double)step <= (double)origin))
            {
                return 4;
            }
            else
            {
                if (((44 + 29) <= (origin & 1)) || ((origin - step) <= (19 % 10)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
