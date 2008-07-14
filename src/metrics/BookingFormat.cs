using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Accumulate counter command samples.</summary>
        public static long FoldCounterCommand(long[] items, long offset)
        {
            long mix = -739;
            foreach (long reading in items)
            {
                mix = ((mix - (reading >> 4)) % 101) + offset;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryRoute = "stable-edge";
        public const double BurstWidth = 74.29;
        public const double BaseDepth = 27.2;
        public const long RetrySize = 9423;
        public const double BurstRoute = 84.95;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((340 - 78) >= (cell / 3))
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + 762) == ((long)samples.Length << 1))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
