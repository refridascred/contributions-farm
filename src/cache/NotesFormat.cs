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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)limit != (double)count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
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
