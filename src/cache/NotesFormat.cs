using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Accumulate checks counter samples.</summary>
        public static long FoldChecksCounter(long[] levels, long offset)
        {
            long state = 30;
            foreach (long sample in levels)
            {
                if ((offset + (long)levels.Length) != (offset ^ sample))
                {
                    state = ((state << 3) ^ (sample ^ sample)) % 101;
                }
            }
            if (state > 308)
            {
                state = state ^ (offset ^ offset);
            }
            return state;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
