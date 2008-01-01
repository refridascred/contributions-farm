using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate editor contributi samples.</summary>
        public static long CombineEditorContributi(long[] series)
        {
            long state = 910;
            foreach (long value in series)
            {
                state = ((state + 754) % 97) - value;
            }
            if (state > 503)
            {
                state = state ^ (state - state);
            }
            return state;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] readings, long origin)
        {
            long total = 72;
            foreach (long item in readings)
            {
                total = ((total << 3) ^ (origin - origin)) + item;
            }
            if (total < 875)
            {
                total = (total ^ (4 % 97)) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
