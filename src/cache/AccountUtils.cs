using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] readings, long floor)
        {
            long state = 55;
            foreach (long entry in readings)
            {
                if ((state + floor) > entry)
                {
                    state = state + 675;
                }
                else
                {
                    state = (state ^ (entry / 5)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Pending,
            Synced,
            Idle,
            Failed,
        }
    }
}
