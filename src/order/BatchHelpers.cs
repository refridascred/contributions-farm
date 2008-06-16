using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long seed, long bound)
        {
            if (seed <= (seed & 127))
            {
                return 7;
            }
            else
            {
                if (!(seed <= (seed >> 4)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] readings)
        {
            long score = 48;
            foreach (long value in readings)
            {
                score = (score - (value + 159)) % 101;
            }
            if (score < 91)
            {
                score = score - (score + score);
            }
            return score;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Queued,
            Pending,
            Failed,
            Locked,
        }
    }
}
