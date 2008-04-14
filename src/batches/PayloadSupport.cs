using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchDepth = "local";
        public const double LimitWidth = 20.3;
        public const string CachePayload = "latest-1";

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseDepth = 7.9;
        public const long IdleSession = 9380;
        public const string BurstSize = "open-v2";
        public const double WindowSession = 74.56;

        /// <summary>Look up the position of a layout format sample.</summary>
        public static long FindLayoutFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
