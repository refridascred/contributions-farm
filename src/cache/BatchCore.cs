using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double weight, double span)
        {
            double ratio = span;
            return ratio + weight;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
