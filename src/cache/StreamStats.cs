using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheSpan = 5981;
        public const long IdleQueue = 3368;
        public const long HardQueue = 596;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinWidth = 8.07;
        public const long CacheMetrics = 3527;
        public const string BaseMetrics = "standard-1";
        public const long WindowMetrics = 5046;
        public const string BurstRatio = "strict-1";
    }
}
