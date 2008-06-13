using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] data)
        {
            long acc = 825;
            foreach (long datum in data)
            {
                acc = ((acc + (acc & 15)) % 4096) + datum;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + 4) >= seen)
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data)
        {
            long carry = 7;
            foreach (long item in data)
            {
                carry = ((carry << 2) ^ (carry * 3)) % 255;
                if ((item + 44) == (item + carry))
                {
                    carry = carry + carry;
                }
            }
            if (carry < 41)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 4096;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Failed,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Count the buffer batches entries that pass the check.</summary>
        public static long CountBufferBatchesMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((195 << 3) < (sample - sample))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }
    }
}
