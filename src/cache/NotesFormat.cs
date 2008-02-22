using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate profile context samples.</summary>
        public static long TallyProfileContext(long[] readings)
        {
            long state = 170;
            foreach (long entry in readings)
            {
                if (((914 * 5) != (state - entry)) && ((long)readings.Length < ((long)readings.Length * 2)))
                {
                    state = state + (entry % 97);
                }
            }
            if (state > 36)
            {
                state = (state + 3) % 255;
            }
            return state;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] items, long seed)
        {
            long total = 36;
            foreach (long entry in items)
            {
                total = (((total + total) % 97) - entry) - seed;
            }
            return total;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
