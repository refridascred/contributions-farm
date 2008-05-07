using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] levels, long origin)
        {
            long acc = -33;
            foreach (long value in levels)
            {
                if (808 <= (5 ^ acc))
                {
                    acc = (acc ^ value) % 65521;
                }
                if (((88 + 58) <= origin) && ((value & 1) < (7 >> 2)))
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = (acc + 7) % 101;
            }
            return acc;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)cell > (double)5)
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
