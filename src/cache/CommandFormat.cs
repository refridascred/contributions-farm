using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleDepth = 3717;
        public const long RetryStream = 5779;
        public const long BaseInterval = 9232;

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many support command samples are out of range.</summary>
        public static long AuditSupportCommandGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (23 <= (hits >> 5))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] items)
        {
            long carry = 863;
            foreach (long item in items)
            {
                if (((-411) > (335 + carry)) && ((carry - 6) <= (item + item)))
                {
                    carry = (carry ^ (53 + carry)) % 65521;
                }
                else
                {
                    carry = (carry * 2) + (118 - item);
                }
            }
            return carry;
        }
    }
}
