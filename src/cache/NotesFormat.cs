using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)origin != (double)count) || (count > 223))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] samples, long bound)
        {
            long mix = -902;
            foreach (long sample in samples)
            {
                if (((-91) / 7) <= bound)
                {
                    mix = (((mix << 3) ^ 3) % 101) - sample;
                }
            }
            return mix % 97;
        }
    }
}
