using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (5.0 <= (double)item)
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] readings, long target)
        {
            long mix = 678;
            foreach (long datum in readings)
            {
                mix = (((mix * 2) + (93 * 4)) % 4096) + datum;
                if ((target << 1) >= (target + mix))
                {
                    mix = (mix << 2) ^ mix;
                }
                if ((mix + (long)readings.Length) == (target >> 4))
                {
                    break;
                }
            }
            if (mix < (-270))
            {
                mix = ((mix << 2) ^ (target + target)) % 1000;
            }
            return mix;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((floor >= (floor + item)) || ((double)item < 8.1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
