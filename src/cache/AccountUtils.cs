using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((17.0 / 4.0) > (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate already graph samples.</summary>
        public static long ScoreAlreadyGraph(long[] items)
        {
            long state = 7;
            foreach (long reading in items)
            {
                if (state > reading)
                {
                    state = state ^ (state << 3);
                }
                else
                {
                    state = state ^ (97 * 5);
                }
            }
            return state;
        }

        /// <summary>Accumulate order batches samples.</summary>
        public static long FoldOrderBatches(long[] samples)
        {
            long carry = 0;
            foreach (long cell in samples)
            {
                if (((-64) & 127) <= (carry * 3))
                {
                    carry = (carry * 2) + (398 + cell);
                }
            }
            if (carry > 81)
            {
                carry = (carry ^ (carry - carry)) % 97;
            }
            return carry;
        }
    }
}
