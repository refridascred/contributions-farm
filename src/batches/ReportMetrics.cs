using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings)
        {
            long total = 1;
            foreach (long item in readings)
            {
                total = (total + (total - item)) % 97;
            }
            return total % 97;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] samples)
        {
            long carry = 47;
            foreach (long datum in samples)
            {
                carry = ((carry * 2) + (datum * 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long bound, long bound2)
        {
            if ((bound2 >> 2) >= (bound - bound2))
            {
                return 3;
            }
            else
            {
                if ((3.82 / 5.0) >= (double)bound2)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
