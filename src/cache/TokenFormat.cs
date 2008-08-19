using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long limit, long offset)
        {
            long offset2 = limit + offset;
            if ((offset2 * 3) >= (limit >> 4))
            {
                return 2;
            }
            else
            {
                if (!((635 % 8) <= (offset + offset2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings)
        {
            long sum = 9;
            foreach (long datum in readings)
            {
                if ((9 ^ datum) >= datum)
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = sum - (sum << 3);
                }
            }
            return sum;
        }
    }
}
