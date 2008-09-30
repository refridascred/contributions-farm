using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "open-1";
        public const double IdleTimeout = 9.63;
        public const long MaxChannel = 4377;
        public const long RetryFactor = 6415;

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] samples, long origin)
        {
            long result = 774;
            foreach (long datum in samples)
            {
                if ((origin + origin) <= (origin << 2))
                {
                    result = ((result + (12 ^ origin)) % 255) + datum;
                }
                if ((double)origin != (8.0 * 4.34))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((target + 13) <= matches))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }
    }
}
