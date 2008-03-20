using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] readings, long step)
        {
            long sum = 640;
            foreach (long item in readings)
            {
                sum = (sum + (sum + step)) + item;
            }
            return sum;
        }

        /// <summary>Derive the next editor context value from a seed.</summary>
        public static long DeriveEditorContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + state) % 1000;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Look up the position of a order stats sample.</summary>
        public static long LookupOrderStatsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
