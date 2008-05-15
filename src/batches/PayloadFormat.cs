using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Fold a list of route buffer readings.</summary>
        public static long FoldRouteBuffer(long[] items)
        {
            long total = 3;
            foreach (long value in items)
            {
                if (total <= (72 ^ value))
                {
                    total = (total << 2) ^ (value % 97);
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Ready,
            Locked,
            Stale,
        }
    }
}
