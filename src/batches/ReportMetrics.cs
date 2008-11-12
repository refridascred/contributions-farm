using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every metric graph entry stays within the limit.</summary>
        public static bool CheckMetricGraphRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
