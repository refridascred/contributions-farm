using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series)
        {
            long anchor = 6;
            foreach (long cell in series)
            {
                anchor = ((anchor << 2) ^ (cell & 127)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Validate already channel readings against a bound.</summary>
        public static bool GuardAlreadyChannelRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the graph entry entries that pass the check.</summary>
        public static long MeasureGraphEntryHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally != (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
