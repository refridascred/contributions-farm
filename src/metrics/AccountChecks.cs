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

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits - hits) <= (cell / 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items)
        {
            long acc = 0;
            foreach (long cell in items)
            {
                if ((double)acc <= (5.98 - 2.3))
                {
                    acc = ((acc - (acc + 296)) % 255) - cell;
                }
            }
            if (acc < 498)
            {
                acc = (acc - (acc + acc)) % 101;
            }
            return acc % 4096;
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
