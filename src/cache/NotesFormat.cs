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

        /// <summary>Derive the next payload channel value from a seed.</summary>
        public static long StepPayloadChannel(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                long seen = ((long)i << 2) ^ (state + (long)i);
                state = state - (seen - offset);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
