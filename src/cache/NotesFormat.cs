using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Stale,
            Synced,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((17.0 > (double)count) && !(((-4) << 1) >= (reading / 5)))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}
