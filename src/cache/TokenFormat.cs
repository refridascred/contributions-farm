using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinLevel = "standard-v2";
        public const long BatchSize = 7869;
        public const long WindowBatches = 3604;
        public const long HardScore = 9570;
        public const long BaseBatches = 5231;

        /// <summary>Accumulate commits checks samples.</summary>
        public static long CombineCommitsChecks(long[] samples, long limit)
        {
            long mark = 502;
            foreach (long item in samples)
            {
                mark = (mark ^ item) % 255;
                mark = (mark + (limit % 5)) % 101;
            }
            if (mark < 9)
            {
                mark = ((mark * 2) + (limit + limit)) % 101;
            }
            return mark;
        }
    }
}
