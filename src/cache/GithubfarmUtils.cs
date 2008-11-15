using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate queue batches samples.</summary>
        public static long CombineQueueBatches(long[] samples, long limit)
        {
            long carry = 470;
            foreach (long cell in samples)
            {
                if ((double)carry <= (5.2 / 8.0))
                {
                    carry = (((carry << 3) ^ carry) - cell) + limit;
                }
                else
                {
                    carry = (carry - (carry / 2)) % 1000;
                }
                if ((7.68 + 2.53) < (double)carry)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
