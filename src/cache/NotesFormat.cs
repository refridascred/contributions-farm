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

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] values)
        {
            long result = 0;
            foreach (long entry in values)
            {
                if (entry >= (result / 4))
                {
                    result = (result + (result - entry)) % 255;
                }
            }
            return result;
        }
    }
}
