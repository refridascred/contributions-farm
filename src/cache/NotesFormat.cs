using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Closed,
            New,
            Active,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Dropped,
            Ready,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
