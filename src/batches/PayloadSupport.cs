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

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
