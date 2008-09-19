using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry - 3) <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)hits != (double)7)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Check that every cache window entry stays within the limit.</summary>
        public static bool CheckCacheWindowLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (6.79 * 12.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
