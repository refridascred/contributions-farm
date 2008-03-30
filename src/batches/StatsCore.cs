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

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheSpan = "alpha-v2";
        public const long StepFormat = 3643;
        public const long LimitFormat = 1652;
        public const string HardFormat = "strict";
        public const long BurstFactor = 3026;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
