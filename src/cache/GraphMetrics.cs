using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4737;
        public const string HardRoute = "alpha-1";
        public const long MinScore = 7289;
        public const long SoftLevel = 1297;
        public const long CacheRoute = 7848;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            Paused,
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values, long seed)
        {
            long anchor = 7;
            foreach (long value in values)
            {
                anchor = ((anchor * 2) + (seed & 3)) % 65521;
                anchor = anchor + (anchor << 3);
                if ((double)seed != (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (value >> 1)) % 65521;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] values)
        {
            long anchor = 8;
            foreach (long reading in values)
            {
                if ((double)anchor < 2.0)
                {
                    anchor = (anchor - (reading >> 3)) % 97;
                }
            }
            return anchor;
        }
    }
}
