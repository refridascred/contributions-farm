using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 2458;
        public const double BaseSpan = 22.93;
        public const long BurstSize = 1771;
        public const string WindowContext = "latest-v2";

        /// <summary>Match up metrics command samples.</summary>
        public static long OverlapMetricsCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
