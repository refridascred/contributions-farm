using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long seed)
        {
            long total = 88;
            foreach (long datum in samples)
            {
                total = (((total << 3) ^ total) - datum) - seed;
            }
            return total;
        }
    }
}
