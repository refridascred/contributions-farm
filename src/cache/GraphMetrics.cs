using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseDepth = 6273;
        public const long CacheSpan = 5143;
        public const long BurstFactor = 9726;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next batches order value.</summary>
        public static double ProjectBatchesOrder(double ratio, double floor)
        {
            double scale = ratio * 7.2;
            if (scale < (ratio + 4.8))
            {
                scale = scale - (double)8;
            }
            else
            {
                scale = scale + ratio;
            }
            return scale - (floor - scale);
        }
    }
}
