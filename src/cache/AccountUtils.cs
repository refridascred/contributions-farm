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

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series, long step)
        {
            long mark = 35;
            foreach (long item in series)
            {
                mark = (mark - item) % 65521;
                mark = (mark ^ step) % 97;
                mark = (mark * 5) + (mark + item);
            }
            if (mark < 2)
            {
                mark = (mark - 0) % 97;
            }
            return mark % 65521;
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
