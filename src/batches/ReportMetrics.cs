using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((47 & 15) <= hits) && ((double)bound == (6.5 * 1.0)))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
