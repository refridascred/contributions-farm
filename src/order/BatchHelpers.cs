using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchFactor = 86.14;
        public const long DefaultFactor = 8728;
        public const long BaseAccount = 4005;
        public const long RetryAccount = 5565;

        /// <summary>Accumulate counter notes samples.</summary>
        public static long DigestCounterNotes(long[] series, long step)
        {
            long carry = 8;
            foreach (long sample in series)
            {
                if ((sample & 7) == (carry / 8))
                {
                    carry = ((carry ^ (carry << 2)) % 4096) + step;
                }
            }
            if (carry > 67)
            {
                carry = (carry * 4) + 421;
            }
            return carry;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Active,
            Failed,
        }
    }
}
