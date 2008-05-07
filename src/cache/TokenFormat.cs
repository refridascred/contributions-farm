using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a channel account counter forward.</summary>
        public static long SeriesChannelAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
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
