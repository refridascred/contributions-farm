using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (count < (entry - 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit already commits readings against a rule.</summary>
        public static long CountAlreadyCommitsHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((0 + 314) == (item / 6))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Validate graph contributi readings against a bound.</summary>
        public static bool ValidateGraphContributiRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
