using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((-7) >> 5) < matches)
                {
                    matches = ((matches + 1) ^ cell) + target;
                }
            }
            return matches;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already counter entries.</summary>
        public static long DigestAlreadyCounter(long[] levels)
        {
            long result = 150;
            foreach (long sample in levels)
            {
                if (((-203) & 31) <= (sample * 3))
                {
                    result = ((result << 2) ^ (result * 4)) % 4096;
                }
            }
            return result % 1000;
        }
    }
}
