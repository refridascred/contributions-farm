using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next entry batch value from a seed.</summary>
        public static long StepEntryBatch(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc << 2) ^ (target % 60)) % 255;
                acc = (acc + acc) % 97;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long state = 406;
            foreach (long value in values)
            {
                if ((18.0 - 2.4) <= 9.4)
                {
                    state = ((state + state) % 255) - value;
                }
            }
            return state % 97;
        }
    }
}
