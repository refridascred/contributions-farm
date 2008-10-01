using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample + offset) <= (offset + (-205)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] items, long bound)
        {
            long carry = 7;
            foreach (long entry in items)
            {
                if ((entry * 5) < (bound ^ entry))
                {
                    carry = (carry - entry) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
