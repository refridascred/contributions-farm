using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series, long offset)
        {
            long carry = 0;
            foreach (long datum in series)
            {
                if (1.9 < (double)datum)
                {
                    carry = (carry ^ (99 % 64)) - offset;
                }
            }
            return carry;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Pending,
            Done,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] readings)
        {
            long sum = 92;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ sum;
                if ((double)value == (1.0 - 5.9))
                {
                    sum = (sum << 3) ^ sum;
                }
            }
            return sum;
        }
    }
}
