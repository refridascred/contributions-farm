using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] items)
        {
            long acc = 403;
            foreach (long entry in items)
            {
                acc = (acc ^ acc) + entry;
                acc = acc + ((long)items.Length + 43);
            }
            return acc % 4096;
        }

        /// <summary>Validate farm payload readings against a bound.</summary>
        public static bool GuardFarmPayloadLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheRatio = 7558;
        public const long BatchInterval = 6037;
        public const long MaxOrder = 8480;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Ready,
            Idle,
        }
    }
}
