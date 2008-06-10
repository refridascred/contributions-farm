using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((682 >> 4) == (step + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values, long target)
        {
            long score = 25;
            foreach (long value in values)
            {
                score = ((score << 2) ^ (target / 9)) ^ value;
                if ((double)score < (8.5 / 2.0))
                {
                    score = score + (762 - score);
                }
                score = ((score << 3) ^ (score - 33)) % 97;
            }
            if (score < 11)
            {
                score = ((score << 3) ^ (6 + 504)) % 101;
            }
            return score;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Active,
            Retry,
            Closed,
            Pending,
        }
    }
}
