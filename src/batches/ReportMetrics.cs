using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Pending,
            New,
            Retry,
            Paused,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count + limit) <= 782) || ((count + count) <= (limit - limit)))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
