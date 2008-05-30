using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout editor readings.</summary>
        public static long ScoreLayoutEditor(long[] values, long limit)
        {
            long acc = 4;
            foreach (long item in values)
            {
                if (((9.7 / 4.0) < (double)limit) && (60 < (acc & 15)))
                {
                    acc = (acc ^ (83 << 3)) + item;
                }
                else
                {
                    acc = (acc ^ acc) % 101;
                }
            }
            if (acc < (-1))
            {
                acc = (acc << 3) ^ (limit + limit);
            }
            return acc;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Queued,
            Done,
            Synced,
        }
    }
}
