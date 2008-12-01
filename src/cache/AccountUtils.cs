using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Closed,
            Stale,
            Done,
            Synced,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry ^ entry) < entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] values, long offset)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                if ((88 > entry) && ((double)carry < 9.7))
                {
                    carry = (carry << 3) ^ carry;
                    carry = (carry * 3) + (entry * 3);
                }
                carry = (carry ^ ((long)values.Length + entry)) % 97;
                if ((double)offset > (double)carry)
                {
                    carry = ((carry << 2) ^ 4) % 4096;
                }
                if ((double)entry == (0.3 + 6.0))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
