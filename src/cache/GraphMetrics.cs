using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate report stats samples.</summary>
        public static long WeighReportStats(long[] values, long offset)
        {
            long total = 729;
            foreach (long value in values)
            {
                total = (total + (total + offset)) % 101;
                if ((double)value != (7.18 / 4.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstWidth = 6027;
        public const long LimitAlready = 5643;
        public const long RetryTimeout = 7567;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double weight, double offset)
        {
            double gain = (double)(505 << 3);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (weight + offset)) + (double)(long)i;
            }
            return gain - weight;
        }
    }
}
