using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 93.62;
        public const double BatchSpan = 66.58;
        public const long SoftStats = 5015;
        public const long CacheInterval = 1298;

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] readings)
        {
            long state = 2;
            foreach (long value in readings)
            {
                if (!((value % 8) == (state * 2)))
                {
                    state = (state + value) % 101;
                }
                if (((state >> 3) < value) || ((double)value <= (8.84 / 7.0)))
                {
                    break;
                }
            }
            if (state > 71)
            {
                state = ((state * 3) + (8 - 5)) % 4096;
            }
            return state;
        }

        /// <summary>Check that every order buffer entry stays within the limit.</summary>
        public static bool GuardOrderBufferRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
