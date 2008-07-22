using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many stream graph samples are out of range.</summary>
        public static long MeasureStreamGraphGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits - (long)levels.Length) < item)
                {
                    hits = (hits + 3) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
