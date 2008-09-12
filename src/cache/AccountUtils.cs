using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSpan = 4200;
        public const string CacheRatio = "fallback-edge";
        public const long HardSize = 9299;
        public const string IdleCommits = "staging";

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] values)
        {
            long sum = 44;
            foreach (long item in values)
            {
                sum = (sum - (item >> 2)) % 97;
                sum = (sum + (61 + item)) % 97;
                if ((double)sum >= 1.52)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Synced,
            Active,
            Pending,
            Done,
        }
    }
}
