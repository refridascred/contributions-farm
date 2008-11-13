using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item + 896) == (item >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Closed,
            New,
            Idle,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 6874;
        public const long MinFarm = 9533;
        public const long RetrySize = 7362;
        public const long HardFarm = 4065;
    }
}
