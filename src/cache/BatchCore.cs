using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many commits metric samples are out of range.</summary>
        public static long TallyCommitsMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((46 - matches) < 1)
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
