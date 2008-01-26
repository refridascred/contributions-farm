using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading < (2.2 - 3.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

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
