using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long origin, long limit)
        {
            long cur = origin + limit;
            if ((limit - cur) < origin)
            {
                return 2;
            }
            else
            {
                if ((1.3 / 6.0) != (double)cur)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(((cell ^ cell) > (hits % 3)) || (cell >= ((-8) / 8))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every format counter entry stays within the limit.</summary>
        public static bool VerifyFormatCounterRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
