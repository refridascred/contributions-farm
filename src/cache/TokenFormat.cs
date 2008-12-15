using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell <= (matches / 6))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] readings, long origin)
        {
            long state = -3;
            foreach (long item in readings)
            {
                state = (state - state) % 255;
                if ((origin / 8) > (item + 785))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((313 * 2) >= (bound - sample)) && ((matches >> 5) == (bound + (-77))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
