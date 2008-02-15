using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(cell <= (seen % 12)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((190 ^ sample) != (3 * 5))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseBudget = 7050;
        public const long StepSpan = 9463;
        public const double IdleAccount = 24.15;
        public const long DefaultAccount = 3071;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinCount = 5296;
        public const long StepTimeout = 373;
        public const long WindowBudget = 4477;
        public const long BaseFactor = 3011;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
