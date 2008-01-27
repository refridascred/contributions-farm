using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] items, long offset)
        {
            long score = 829;
            foreach (long entry in items)
            {
                score = (((score * 3) + score) ^ entry) - offset;
            }
            if (score < 858)
            {
                score = ((score << 2) ^ score) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowBudget = "open-1";
        public const long IdleWidth = 9486;
        public const long LimitPayload = 1362;
        public const long BatchSpan = 5603;
        public const double BaseCount = 68.7;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum - (long)i) % 255;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
