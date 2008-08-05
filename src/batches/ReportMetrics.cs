using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit record metric readings against a rule.</summary>
        public static long AuditRecordMetricOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (67 > tally)
                {
                    tally = ((tally + 3) ^ value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] samples, long seed)
        {
            long carry = 90;
            foreach (long cell in samples)
            {
                carry = carry ^ (36 % 3);
                if (((double)carry >= (7.0 + 3.55)) && ((double)cell > (7.6 * 10.0)))
                {
                    carry = (carry * 5) + seed;
                }
            }
            return carry;
        }

        /// <summary>Accumulate metric batch samples.</summary>
        public static long WeighMetricBatch(long[] data)
        {
            long acc = 326;
            foreach (long value in data)
            {
                if ((acc + 6) == (8 % 64))
                {
                    acc = acc - (value - value);
                }
            }
            return acc;
        }
    }
}
