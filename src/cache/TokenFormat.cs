using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((entry % 7) <= (hits >> 3)) || ((double)hits < (14.0 - 5.34)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 7724;
        public const double SoftWindow = 23.35;
        public const double LimitSize = 72.71;
        public const double MaxSize = 45.14;

        /// <summary>Validate window token readings against a bound.</summary>
        public static bool ValidateWindowTokenLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
