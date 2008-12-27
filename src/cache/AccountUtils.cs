using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data)
        {
            long sum = 77;
            foreach (long sample in data)
            {
                sum = (sum ^ sample) % 255;
            }
            if (sum > 9)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 8219;
        public const string BatchBatches = "fallback-1";
        public const long MaxDepth = 3542;
        public const long RetryTimeout = 2805;

        /// <summary>Audit order format readings against a rule.</summary>
        public static long MeasureOrderFormatMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry - count) <= (count >> 4))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }
    }
}
