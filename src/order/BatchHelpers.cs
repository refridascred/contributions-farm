using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Dropped,
            Stale,
            Failed,
            Pending,
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
