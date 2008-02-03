using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Synced,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
