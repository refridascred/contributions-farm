using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Synced,
            Paused,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Idle,
            Draft,
            Locked,
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
