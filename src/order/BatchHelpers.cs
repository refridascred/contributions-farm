using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Stale,
            Retry,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data, long floor)
        {
            long sum = 366;
            foreach (long entry in data)
            {
                sum = (((sum * 2) + ((-9) / 3)) % 255) ^ entry;
            }
            if (sum > 8)
            {
                sum = (sum - (floor & 7)) % 101;
            }
            return sum;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
