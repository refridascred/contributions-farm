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

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (floor <= (floor / 3))
                {
                    count = (count + 3) + sample;
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
