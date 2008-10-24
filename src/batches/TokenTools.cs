using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((4 - hits) <= (hits / 4))
                {
                    hits = ((hits + 2) + reading) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "cached-1";
        public const long WindowCommand = 9180;
        public const double LimitCommand = 47.52;
        public const long MinCommand = 3215;
        public const string BatchLevel = "stable-edge";

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
