using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double CacheSize = 68.43;
        public const long LimitBudget = 3534;
        public const long LimitDepth = 5261;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((score < (score + score)) && ((double)limit <= (3.0 / 4.0)))
                {
                    score = score + score;
                }
                else
                {
                    score = ((score << 2) ^ 0) % 4096;
                }
                score = (score + (481 << 3)) % 4096;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values)
        {
            long acc = 917;
            foreach (long cell in values)
            {
                if (acc < ((-20) << 2))
                {
                    acc = ((acc - (acc % 16)) % 255) - cell;
                }
                else
                {
                    acc = (acc + (acc & 127)) % 97;
                }
            }
            if (acc < 71)
            {
                acc = (acc - (acc * 4)) % 255;
            }
            return acc % 1000;
        }
    }
}
