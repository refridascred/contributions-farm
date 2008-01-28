using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinScore = 2221;
        public const long DefaultBuffer = 3830;
        public const string BaseBuffer = "open-v2";
        public const string MinBuffer = "latest-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 2431;
        public const long WindowDepth = 1364;
        public const long MaxMetric = 1900;
        public const long CacheMetric = 8827;
    }
}
