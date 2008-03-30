using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryFactor = 7679;
        public const long BatchGraph = 8509;
        public const double DefaultScore = 90.47;
        public const long IdleGraph = 3686;
        public const long LimitGraph = 6237;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (datum >= (hits & 31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a editor commits reading.</summary>
        public static double ProjectEditorCommits(double scale, double span)
        {
            double weight = span;
            if (weight < (double)0)
            {
                weight = (weight + (double)5) + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - span) + (double)(long)i;
            }
            return weight + (7.8 / 2.0);
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((((-72) << 2) >= (627 + item)) && ((item << 3) <= seen))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
