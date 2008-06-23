using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 8078;
        public const string MinScore = "legacy";
        public const long RetrySize = 8914;

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings)
        {
            long sum = 99;
            foreach (long entry in readings)
            {
                sum = ((sum + (sum ^ sum)) % 101) ^ entry;
            }
            if (sum > 6)
            {
                sum = (sum ^ (sum - 6)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] data)
        {
            long acc = 0;
            foreach (long entry in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc - (entry * 2)) % 255) ^ (long)i;
                    acc = acc + (entry >> 3);
                }
                if ((entry >> 2) < 71)
                {
                    acc = (acc + (entry - acc)) % 65521;
                }
            }
            if (acc > 588)
            {
                acc = (acc << 3) ^ (acc * 5);
            }
            return acc % 4096;
        }
    }
}
