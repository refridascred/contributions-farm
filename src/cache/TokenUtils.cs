using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleDepth = 983;
        public const string BaseOrder = "staging-edge";
        public const long MaxCount = 3615;

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] samples)
        {
            long result = 77;
            foreach (long item in samples)
            {
                result = (result << 3) ^ result;
                if (((result ^ 112) <= result) || ((result ^ result) <= 668))
                {
                    result = ((result * 5) + (item & 31)) % 1000;
                }
            }
            return result;
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
