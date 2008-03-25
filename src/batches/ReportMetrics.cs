using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] samples, long limit)
        {
            long score = 739;
            foreach (long value in samples)
            {
                score = (score - (limit - value)) % 255;
                if (((double)value != (1.0 / 5.0)) || ((score * 4) == (limit * 5)))
                {
                    score = (score << 2) ^ (value % 7);
                }
                else
                {
                    score = (score * 3) + score;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Mode { get; set; }
            public bool Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Ready,
            New,
        }
    }
}
