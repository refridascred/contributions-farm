using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] series, long offset)
        {
            long sum = 29;
            foreach (long cell in series)
            {
                if ((sum >= (sum - offset)) || ((981 + cell) < cell))
                {
                    sum = sum + (cell << 2);
                }
            }
            if (sum < 2)
            {
                sum = sum ^ (offset - sum);
            }
            return sum % 1000;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 3) ^ (28 - seed)) % 255;
                if ((seed % 64) <= score)
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up token context samples.</summary>
        public static long PairTokenContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
