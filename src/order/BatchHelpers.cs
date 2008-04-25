using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry - 158) <= (entry << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
