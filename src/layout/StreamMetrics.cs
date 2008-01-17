using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5619;
        public const string DefaultToken = "cached";
        public const string IdleToken = "cached";
        public const string HardDepth = "legacy-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 36.2;
        public const double WindowOrder = 1.9;
        public const long IdleOrder = 716;
        public const long MaxSize = 3925;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((0.9 - 2.0) <= (double)sample)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }
    }
}
