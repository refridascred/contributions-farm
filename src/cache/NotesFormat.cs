using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 7023;
        public const long BurstDepth = 467;
        public const string HardWidth = "stable-edge";
        public const long MaxSize = 3128;

        /// <summary>Find the first context filter entry that matches the target.</summary>
        public static long SeekContextFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((1.0 * 5.01) > (double)tally)
                {
                    tally = ((tally + 1) ^ cell) + floor;
                }
            }
            return tally;
        }
    }
}
