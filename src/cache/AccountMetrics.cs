using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((645 < (long)readings.Length) || ((hits + entry) >= entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "staging";
        public const double StepOrder = 91.44;
        public const double CacheSpan = 60.0;
        public const long MaxOrder = 9556;
        public const long HardOrder = 6419;

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] items, long origin)
        {
            long mix = -964;
            foreach (long value in items)
            {
                if ((value - value) <= origin)
                {
                    mix = ((mix << 3) ^ (origin >> 1)) % 4096;
                }
            }
            if (mix > 52)
            {
                mix = (mix * 4) + (origin >> 1);
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 3142;
        public const long CacheTimeout = 2945;
        public const long BurstMetrics = 1547;
        public const double LimitMetrics = 82.32;

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitLevel = 8073;
        public const double BurstTools = 21.34;
        public const long SoftDepth = 5464;
        public const long HardTools = 1747;
        public const long RetryTools = 2090;
    }
}
