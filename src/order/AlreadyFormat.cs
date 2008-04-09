using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double StepDepth = 98.58;
        public const long SoftRatio = 2339;
        public const long WindowCommand = 4612;
        public const long WindowRatio = 1926;

        /// <summary>Count the order layout entries that pass the check.</summary>
        public static long AuditOrderLayoutMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((offset << 3) == ((-18) / 6)))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items)
        {
            long acc = 30;
            foreach (long item in items)
            {
                acc = acc - item;
                if ((acc & 3) != (item << 1))
                {
                    acc = (acc ^ (333 & 3)) % 101;
                }
                else
                {
                    acc = acc - (412 + item);
                }
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 7453;
        public const long HardInterval = 8165;
        public const string BurstMetric = "cached-v2";

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
