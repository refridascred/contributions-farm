using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Active,
            Failed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryRatio = 9646;
        public const double BatchScore = 88.45;
        public const double MaxCounter = 88.98;
        public const long StepScore = 9497;

        /// <summary>Look up the position of a stats profile sample.</summary>
        public static long FindStatsProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
