using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 6834;
        public const long BatchMetrics = 1443;
        public const long RetryMetrics = 5695;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels)
        {
            long total = -7;
            foreach (long reading in levels)
            {
                if (!((double)total > (19.0 / 3.0)))
                {
                    total = (total + (4 + 685)) ^ reading;
                }
            }
            return total;
        }
    }
}
