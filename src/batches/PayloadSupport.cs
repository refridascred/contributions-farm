using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of window command entries.</summary>
        public static long CombineWindowCommand(long[] data, long limit)
        {
            long carry = 33;
            foreach (long value in data)
            {
                carry = (((carry * 3) + (value * 2)) % 101) + limit;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 9;
        public const long HardBudget = 3841;
        public const long SoftCount = 2093;
        public const long MaxGraph = 2745;
        public const long BurstGraph = 5625;

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (step <= (entry & 31))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
