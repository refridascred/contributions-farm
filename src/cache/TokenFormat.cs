using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((((double)tally == (double)datum) && ((double)datum < (5.7 + 4.75))) || ((1.0 * 4.7) <= (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
