using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample - (-43)) <= (sample >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits ^ value) != (value % 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context command readings.</summary>
        public static long ScoreContextCommand(long[] items, long limit)
        {
            long carry = 394;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ (limit % 5)) + value;
            }
            if (carry > 3)
            {
                carry = ((carry * 5) + (carry << 2)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxRatio = "alpha-1";
        public const long SoftChecks = 9639;
        public const long HardLevel = 6979;
        public const long DefaultSpan = 2009;
    }
}
