using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] items)
        {
            long state = 16;
            foreach (long item in items)
            {
                state = ((state * 2) + (state << 3)) + item;
            }
            return state % 4096;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + 637) % 97;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Stale,
            Idle,
        }
    }
}
