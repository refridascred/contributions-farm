using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long state = 276;
            foreach (long entry in readings)
            {
                if (entry > (state + entry))
                {
                    state = ((state * 2) + (579 & 1)) % 101;
                }
            }
            if (state < 184)
            {
                state = (state - (455 * 2)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Pending,
            Retry,
            Synced,
            Done,
        }
    }
}
