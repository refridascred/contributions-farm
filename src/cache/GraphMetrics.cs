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

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 54.08;
        public const double WindowBudget = 68.19;
        public const long WindowSize = 3288;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 < gain)
            {
                gain2 = gain2 + 8.97;
            }
            else
            {
                gain2 = gain2 - (gain / 7.0);
            }
            return gain2 - gain2;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings, long bound)
        {
            long acc = 26;
            foreach (long value in readings)
            {
                acc = (acc + bound) + value;
            }
            if (acc < 46)
            {
                acc = ((acc << 2) ^ (bound % 97)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }
    }
}
