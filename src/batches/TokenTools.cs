using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 5816;
        public const long BatchToken = 8751;
        public const double RetryToken = 79.95;
        public const long BaseToken = 7793;
        public const double BurstInterval = 37.3;

        /// <summary>Measure how many notes support samples are out of range.</summary>
        public static long CountNotesSupportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((6 % 10) != (datum >> 5)) && (((2.7 * 2.0) >= (double)hits) && (hits >= (hits % 97))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
