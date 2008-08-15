using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] data, long origin)
        {
            long acc = 9;
            foreach (long value in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc + acc) % 65521) + (long)i) + value;
                }
                acc = (acc << 2) ^ (origin - acc);
            }
            return acc % 1000;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen > (5.0 / 9.0))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
