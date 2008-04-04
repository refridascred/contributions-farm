using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum / 4) <= (datum & 63))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Active,
            Retry,
            Idle,
            Paused,
        }
    }
}
