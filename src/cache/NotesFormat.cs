using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Ready,
            Pending,
            Done,
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((340 % 16) == (cell + 34)) && ((hits << 1) == (hits - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
