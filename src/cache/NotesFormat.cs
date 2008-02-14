using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine context stream values into a single score.</summary>
        public static long CombineContextStream(long[] levels, long offset)
        {
            long carry = -1;
            foreach (long datum in levels)
            {
                carry = (((carry ^ (57 & 127)) % 101) + datum) + offset;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many buffer cache samples are out of range.</summary>
        public static long MeasureBufferCacheMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((((limit & 63) >= 23) || ((18.0 * 8.58) <= (double)matches)) || ((9 - limit) != (matches / 3)))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
