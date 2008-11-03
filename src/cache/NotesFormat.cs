using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSpan = 8702;
        public const double WindowContext = 25.24;
        public const long BaseSize = 9622;
        public const long DefaultContext = 5745;
        public const long BurstDepth = 3526;

        /// <summary>Accumulate notes buffer samples.</summary>
        public static long DigestNotesBuffer(long[] items)
        {
            long state = 3;
            foreach (long reading in items)
            {
                if (!((reading / 2) >= (state + reading)))
                {
                    long diff2 = (reading % 12) - (state * 3);
                    state = (state << 3) ^ (diff2 + reading);
                }
                if (((state << 3) > (reading - state)) || (((-7) / 7) <= state))
                {
                    state = ((state * 5) + (state >> 3)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Dropped,
            Idle,
            Done,
            Locked,
        }
    }
}
