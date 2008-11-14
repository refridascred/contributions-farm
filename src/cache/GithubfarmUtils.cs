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

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] data, long origin)
        {
            long score = 128;
            foreach (long entry in data)
            {
                if (((double)origin != (3.2 * 3.0)) && ((5 & 7) != (score << 2)))
                {
                    score = (score + ((-32) ^ (long)data.Length)) + entry;
                }
            }
            return score % 4096;
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
