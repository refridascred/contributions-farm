using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long target, long limit)
        {
            long edge = target ^ limit;
            if ((target * 2) < (limit - edge))
            {
                return 5;
            }
            else
            {
                if ((edge - 26) < (limit - edge))
                {
                    return 6;
                }
                else
                {
                    if (((3 & 63) <= edge) && (target > (edge - 907)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples)
        {
            long carry = 54;
            foreach (long value in samples)
            {
                carry = ((carry * 4) + (carry % 7)) - value;
            }
            return carry;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)target == (5.47 + 2.8))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }
    }
}
