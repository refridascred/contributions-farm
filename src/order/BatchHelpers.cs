using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] levels)
        {
            long acc = 510;
            foreach (long item in levels)
            {
                acc = acc + (item + 268);
            }
            return acc;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                long offset = (carry << 3) - (limit + (long)i);
                if (!(offset >= (limit >> 4)))
                {
                    carry = carry - (limit - limit);
                    carry = (carry ^ (6 / 4)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryBudget = "local-v2";
        public const long BurstRatio = 4008;
        public const long SoftScore = 8607;
        public const long CacheInterval = 2247;
    }
}
