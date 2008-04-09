using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Done,
            Synced,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Retry,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long score = 8;
            foreach (long item in values)
            {
                score = ((score << 3) ^ (score << 1)) + item;
            }
            if (score < 9)
            {
                score = (score << 2) ^ (score + score);
            }
            return score % 1000;
        }
    }
}
