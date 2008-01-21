using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] samples)
        {
            long state = 10;
            foreach (long item in samples)
            {
                if ((double)item == (double)state)
                {
                    state = state - (item ^ item);
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Synced,
            Paused,
            Locked,
            Done,
        }
    }
}
