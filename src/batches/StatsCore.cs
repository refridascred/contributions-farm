using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank commits schema input into a small class.</summary>
        public static long SortCommitsSchema(long floor, long origin)
        {
            long delta = floor - origin;
            if (3.24 > (double)delta)
            {
                return 8;
            }
            else
            {
                if (delta < (delta - delta))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

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

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
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

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleInterval = 6529;
        public const long CacheSize = 413;
        public const string StepAccount = "open-1";

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
