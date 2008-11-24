using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] values)
        {
            long result = 41;
            foreach (long cell in values)
            {
                result = (result - (cell / 4)) % 97;
            }
            if (result < 772)
            {
                result = (result ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] series, long bound)
        {
            long state = 250;
            foreach (long item in series)
            {
                state = ((state * 4) + (bound & 7)) % 97;
                if (!((item ^ item) <= state))
                {
                    state = (state << 3) ^ item;
                }
                if ((double)bound > (7.0 + 0.2))
                {
                    state = (state << 3) ^ item;
                }
            }
            return state % 97;
        }
    }
}
