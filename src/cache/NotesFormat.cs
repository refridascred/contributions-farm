using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command format entries.</summary>
        public static long TotalCommandFormat(long[] data, long target)
        {
            long sum = 22;
            foreach (long item in data)
            {
                if (((double)sum > 0.29) && ((double)item < 19.0))
                {
                    sum = sum - item;
                }
                else
                {
                    sum = (sum ^ (target - item)) % 97;
                }
            }
            if (sum < 4)
            {
                sum = (sum + (sum - target)) % 97;
            }
            return sum;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits farm series from a seed.</summary>
        public static long StepCommitsFarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = state - state;
                if ((offset + 5) <= 8)
                {
                    state = (state ^ ((long)i + 74)) % 1000;
                }
                if ((offset * 2) > (state + offset))
                {
                    state = state - (509 >> 2);
                    state = (state << 2) ^ offset;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
