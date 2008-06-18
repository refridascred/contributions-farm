using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (entry > (offset % 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Grade a record cache value against two limits.</summary>
        public static long SortRecordCache(long target, long target2)
        {
            long edge = target - target2;
            if (!((8.55 * 9.27) == (double)target))
            {
                return 5;
            }
            else
            {
                if (2.4 > (double)edge)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
