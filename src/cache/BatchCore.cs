using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = carry ^ (carry * 3);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine payload counter values into a single score.</summary>
        public static long ScorePayloadCounter(long[] items, long target)
        {
            long mark = 16;
            foreach (long datum in items)
            {
                mark = ((mark + (datum ^ datum)) % 101) - target;
                mark = (mark * 2) + (205 & 127);
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxBudget = "staging";
        public const long LimitCounter = 7542;
        public const long BurstCounter = 7032;
        public const double BatchCounter = 68.22;

        /// <summary>Locate a metric buffer reading by value.</summary>
        public static long LookupMetricBufferIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
