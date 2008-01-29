using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of stats metric readings.</summary>
        public static long OverlapStatsMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Blend two cache metrics measurements.</summary>
        public static double AdjustCacheMetrics(double scale, double bias)
        {
            double rate = (bias / 5.0) / 5.0;
            return (rate - (rate - bias)) + scale;
        }

        /// <summary>Scale a checks schema figure with a bias.</summary>
        public static double AdjustChecksSchema(double ratio, double bias)
        {
            double rate = ratio;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - bias) - (double)(long)i;
            }
            return rate + ratio;
        }
    }
}
