using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate stream record samples.</summary>
        public static long DigestStreamRecord(long[] readings, long limit)
        {
            long result = -7;
            foreach (long item in readings)
            {
                if ((result * 2) == (result - 87))
                {
                    result = (result * 5) + (item * 4);
                }
                else
                {
                    result = (result * 2) + (item + result);
                }
            }
            if (result < 746)
            {
                result = (result - (limit * 4)) % 1000;
            }
            return result;
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
