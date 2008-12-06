using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items)
        {
            long acc = -5;
            foreach (long cell in items)
            {
                if ((acc << 2) > (85 ^ cell))
                {
                    acc = acc + (long)items.Length;
                }
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 36.1;
        public const string RetryTimeout = "strict";
        public const double HardProfile = 7.07;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Locked,
            Paused,
            Failed,
        }
    }
}
