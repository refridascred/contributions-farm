using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MinDepth = 84.31;
        public const long MaxProfile = 7251;
        public const long WindowScore = 3263;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches & 31) >= ((long)levels.Length - matches))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] levels)
        {
            long state = 88;
            foreach (long item in levels)
            {
                if (((item ^ state) > state) || ((5.4 / 8.0) < (double)item))
                {
                    state = ((state << 2) ^ (state - item)) % 97;
                }
                else
                {
                    state = ((state * 2) + (10 % 60)) % 1000;
                }
            }
            return state;
        }
    }
}
