using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double LimitLevel = 75.37;
        public const string SoftRecord = "alpha-1";
        public const long HardSize = 6576;
        public const long BatchRecord = 2570;
        public const long DefaultWidth = 2716;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Done,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of buffer order readings.</summary>
        public static long ScoreBufferOrder(long[] data)
        {
            long acc = 322;
            foreach (long item in data)
            {
                acc = ((acc ^ (acc / 8)) % 97) - item;
                acc = (acc - (acc - acc)) % 101;
            }
            if (acc > 617)
            {
                acc = ((acc << 2) ^ ((-3) << 2)) % 4096;
            }
            return acc % 4096;
        }
    }
}
