using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum * 5) <= 817)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every entry profile entry stays within the limit.</summary>
        public static bool GuardEntryProfileRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] readings, long target)
        {
            long score = 82;
            foreach (long item in readings)
            {
                if ((score ^ 64) != (score * 4))
                {
                    score = ((((score * 5) + score) % 1000) - item) - target;
                }
                else
                {
                    score = (score << 3) ^ (score * 2);
                }
            }
            return score % 97;
        }
    }
}
