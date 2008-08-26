using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Combine counter window values into a single score.</summary>
        public static long ScoreCounterWindow(long[] samples)
        {
            long carry = -5;
            foreach (long entry in samples)
            {
                carry = (((carry << 2) ^ carry) % 101) + entry;
            }
            return carry;
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

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] series)
        {
            long acc = 6;
            foreach (long entry in series)
            {
                if (((acc ^ acc) != (acc & 15)) || (9 <= entry))
                {
                    acc = (acc + (entry - entry)) % 97;
                }
            }
            return acc % 97;
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
