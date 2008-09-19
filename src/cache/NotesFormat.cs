using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit contributi cluster readings against a rule.</summary>
        public static long CountContributiClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + (-26)) != (hits * 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series)
        {
            long carry = 818;
            foreach (long value in series)
            {
                carry = (carry + carry) + value;
                if ((1.07 + 7.3) < (5.89 * 1.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long bound, long bound2)
        {
            if (9.7 < (6.0 * 15.0))
            {
                return 7;
            }
            else
            {
                if ((1.0 + 8.1) != (double)bound2)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
