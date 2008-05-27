using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of window commits entries.</summary>
        public static long WeighWindowCommits(long[] series)
        {
            long result = 4;
            foreach (long item in series)
            {
                result = result - (result / 5);
                result = (result - result) % 65521;
                if ((461 % 16) > item)
                {
                    result = ((result << 3) ^ (item + item)) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ (result + item)) % 255;
                }
            }
            if (result > 8)
            {
                result = (result ^ (result + result)) % 101;
            }
            return result;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Count the batch cache entries that pass the check.</summary>
        public static long TallyBatchCacheGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((2.59 + 1.3) <= (double)value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
