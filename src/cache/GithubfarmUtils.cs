using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count < (17.0 * 8.85))
                {
                    count = ((count + 3) + value) - floor;
                }
            }
            return count;
        }

        /// <summary>Locate a metrics record reading by value.</summary>
        public static long SeekMetricsRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((9 + 61) <= value)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
