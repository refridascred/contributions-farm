using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor + target;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 98.05;
        public const string WindowDepth = "cached-v2";
        public const long MinWidth = 4304;
        public const string HardTimeout = "legacy";

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double scale, double floor)
        {
            double scale2 = scale * 8.97;
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - (scale + floor)) - (double)(long)i;
            }
            return scale2 - (double)514;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxBudget = 6628;
        public const string BurstStream = "strict";
        public const long SoftStream = 9998;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
