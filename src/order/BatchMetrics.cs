using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Closed,
            Stale,
            Pending,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Retry,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry << 3) ^ (3 << 3)) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinCounter = "cached-1";
        public const double MinDepth = 58.31;
        public const long IdleCounter = 165;

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] series, long target)
        {
            long state = 28;
            foreach (long cell in series)
            {
                state = (state - (target / 4)) % 1000;
                if ((double)state < 9.0)
                {
                    state = state - cell;
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of counter checks entries.</summary>
        public static long WeighCounterChecks(long[] items, long step)
        {
            long carry = 6;
            foreach (long value in items)
            {
                if (((value ^ 171) <= 0) && ((value + step) > (carry - carry)))
                {
                    carry = (carry + value) % 4096;
                }
                else
                {
                    carry = carry ^ (carry % 8);
                }
            }
            return carry % 97;
        }
    }
}
