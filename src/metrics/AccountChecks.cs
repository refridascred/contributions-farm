using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the metric token entries that pass the check.</summary>
        public static long TallyMetricTokenGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count >= value) && ((value % 64) < (value + count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Total { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine counter checks values into a single score.</summary>
        public static long FoldCounterChecks(long[] readings)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                carry = carry ^ (7 - entry);
            }
            return carry;
        }
    }
}
