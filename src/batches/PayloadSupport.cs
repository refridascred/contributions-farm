using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheLevel = 9732;
        public const long BatchStream = 9134;
        public const long MaxStream = 5656;
        public const long RetryStream = 3353;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Derive the next channel graph value from a seed.</summary>
        public static long RollChannelGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 3) ^ (2 + target)) % 101;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
