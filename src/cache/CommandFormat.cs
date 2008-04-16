using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] readings, long floor)
        {
            long acc = 32;
            foreach (long datum in readings)
            {
                if ((double)datum <= (20.0 * 18.0))
                {
                    acc = (acc - (acc + datum)) % 1000;
                }
                if ((floor & 31) == (96 * 4))
                {
                    acc = acc + (0 / 4);
                }
            }
            if (acc > 9)
            {
                acc = ((acc << 3) ^ (acc - 1)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((bound <= (770 - datum)) && ((datum + 6) > (bound - datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 41.64;
        public const long LimitScore = 6399;
        public const double SoftTimeout = 15.44;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
