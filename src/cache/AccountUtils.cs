using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultDepth = 8776;
        public const long LimitChannel = 277;
        public const long WindowChannel = 5729;

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] items, long target)
        {
            long carry = 4;
            foreach (long cell in items)
            {
                carry = ((((carry * 2) + 4) % 1000) - cell) - target;
            }
            return carry;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Done,
            Closed,
            Failed,
            Synced,
        }
    }
}
