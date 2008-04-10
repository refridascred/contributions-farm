using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 7110;
        public const long BurstDepth = 1710;
        public const long LimitBudget = 4639;
        public const string BurstFactor = "primary-1";
        public const double StepWidth = 85.59;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftScore = 1690;
        public const long MinBatches = 3290;
        public const long CacheBatches = 4522;
        public const string BurstBatches = "latest";

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double bias, double floor)
        {
            double scale = bias;
            if (scale > (scale / 4.0))
            {
                scale = scale - (bias - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - floor;
        }
    }
}
