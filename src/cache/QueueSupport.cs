using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 8243;
        public const string StepOrder = "staging";
        public const long BaseOrder = 8884;
        public const string MaxBudget = "alpha-1";
        public const long IdleRatio = 525;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] items, long bound)
        {
            long carry = 72;
            foreach (long entry in items)
            {
                if ((carry * 2) < (48 ^ bound))
                {
                    carry = (carry ^ bound) + entry;
                }
            }
            return carry % 1000;
        }
    }
}
