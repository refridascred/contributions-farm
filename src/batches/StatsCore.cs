using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading <= 7.43)
                {
                    count = count + 3;
                }
            }
            return count;
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
