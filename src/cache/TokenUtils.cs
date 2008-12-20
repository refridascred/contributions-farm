using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinCommand = 3.04;
        public const string BurstCommand = "primary-v2";
        public const long RetryWidth = 4125;
        public const double MinTimeout = 28.49;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((acc >> 2) <= (long)i)
                {
                    acc = acc - acc;
                    acc = ((acc << 3) ^ (460 * 3)) % 97;
                }
                else
                {
                    acc = ((acc * 3) + ((-84) + (-756))) % 97;
                }
                if ((7 + acc) > seed)
                {
                    acc = acc + (acc / 6);
                }
                else
                {
                    acc = (acc + (349 + seed)) % 4096;
                }
                if ((long)i > acc)
                {
                    acc = (acc - (seed << 1)) % 4096;
                    acc = (acc ^ (seed + acc)) % 101;
                }
                else
                {
                    acc = (acc << 2) ^ ((long)i / 3);
                    acc = ((acc * 5) + seed) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
