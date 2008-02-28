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

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] data, long limit)
        {
            long state = 67;
            foreach (long entry in data)
            {
                if ((2 - limit) >= state)
                {
                    break;
                }
                if ((53 & 255) == (31 + entry))
                {
                    state = ((state * 5) + (limit % 24)) % 255;
                }
                else
                {
                    state = ((state * 2) + (entry + state)) % 101;
                }
            }
            return state % 97;
        }
    }
}
