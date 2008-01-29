using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Compare every pair of support route readings.</summary>
        public static long OverlapSupportRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
