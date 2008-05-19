using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length + sample) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Queued,
            Done,
            Paused,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double bias, double bias2)
        {
            double weight = 14.0;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (bias - bias2)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
