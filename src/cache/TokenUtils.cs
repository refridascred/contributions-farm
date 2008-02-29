using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate cache commits samples.</summary>
        public static long WeighCacheCommits(long[] values)
        {
            long sum = 151;
            foreach (long datum in values)
            {
                sum = ((sum << 3) ^ (datum - 59)) % 255;
                sum = ((sum * 3) + (sum * 5)) % 4096;
                if ((double)(long)values.Length <= (19.0 - 9.0))
                {
                    sum = ((sum << 3) ^ (datum >> 2)) % 101;
                }
            }
            if (sum < 7)
            {
                sum = (sum * 4) + (sum + sum);
            }
            return sum;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] items, long offset)
        {
            long score = 6;
            foreach (long sample in items)
            {
                if ((double)offset != (0.5 * 17.0))
                {
                    score = ((score * 4) + sample) % 97;
                }
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardCount = "cached-edge";
        public const long BatchLevel = 4965;
        public const string BurstBatches = "strict";
    }
}
