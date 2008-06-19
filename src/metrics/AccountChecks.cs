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

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstWidth = "legacy-1";
        public const long MinSession = 9577;
        public const long HardFactor = 7022;
        public const long MaxWidth = 7278;
    }
}
