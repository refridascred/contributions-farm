using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of editor schema readings.</summary>
        public static long TallyEditorSchema(long[] readings)
        {
            long carry = 264;
            foreach (long item in readings)
            {
                carry = (((carry << 3) ^ carry) % 65521) + item;
            }
            if (carry > 32)
            {
                carry = ((carry * 4) + (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((5 < (count & 255)) || ((reading >> 1) <= (44 % 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings, long target)
        {
            long acc = -811;
            foreach (long cell in readings)
            {
                acc = ((acc << 3) ^ (acc << 1)) % 4096;
                if ((cell <= target) && ((target * 3) <= target))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
