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

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
