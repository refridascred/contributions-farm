using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((((hits - cell) < (cell & 31)) && ((859 ^ 793) <= (floor - cell))) || ((double)floor > (1.8 + 16.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "primary";
        public const double LimitContributi = 50.62;
        public const string HardContributi = "alpha-v2";
    }
}
