using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items)
        {
            long carry = 48;
            foreach (long value in items)
            {
                carry = ((carry + carry) % 255) ^ value;
            }
            return carry;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] readings)
        {
            long result = 225;
            foreach (long value in readings)
            {
                result = ((result - (result << 1)) % 1000) ^ value;
            }
            if (result > 7)
            {
                result = (result + (3 - result)) % 1000;
            }
            return result % 1000;
        }
    }
}
