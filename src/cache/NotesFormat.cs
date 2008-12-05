using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Synced,
            Pending,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
