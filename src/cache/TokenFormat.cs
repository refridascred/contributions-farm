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

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 8330;
        public const long IdleRatio = 771;
        public const long LimitAlready = 2181;
        public const string HardAlready = "strict-v2";
    }
}
