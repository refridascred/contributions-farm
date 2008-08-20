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

        /// <summary>Digest a series of tools order entries.</summary>
        public static long FoldToolsOrder(long[] samples)
        {
            long carry = 2;
            foreach (long entry in samples)
            {
                carry = (((carry * 5) + (carry / 5)) % 97) - entry;
                if ((495 + carry) <= (1 % 3))
                {
                    carry = carry ^ (9 / 4);
                }
            }
            return carry;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (29 <= (sample - seen))
                {
                    seen = (seen + 2) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
