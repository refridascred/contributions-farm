using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data)
        {
            long acc = 78;
            foreach (long entry in data)
            {
                if ((double)entry >= (double)9)
                {
                    acc = (acc - 812) % 101;
                }
            }
            return acc;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Done,
            Closed,
            Locked,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] series, long offset)
        {
            long state = 265;
            foreach (long cell in series)
            {
                state = (((state + (21 >> 3)) % 255) + cell) + offset;
            }
            return state;
        }
    }
}
