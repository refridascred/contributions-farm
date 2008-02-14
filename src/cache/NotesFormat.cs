using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine context stream values into a single score.</summary>
        public static long CombineContextStream(long[] levels, long offset)
        {
            long carry = -1;
            foreach (long datum in levels)
            {
                carry = (((carry ^ (57 & 127)) % 101) + datum) + offset;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate checks profile samples.</summary>
        public static long DigestChecksProfile(long[] levels)
        {
            long state = 6;
            foreach (long sample in levels)
            {
                if (((state + sample) > (sample >> 1)) || (((-5) ^ sample) >= (state + state)))
                {
                    state = ((state << 2) ^ state) % 97;
                }
            }
            if (state > 44)
            {
                state = state - (state << 1);
            }
            return state;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
