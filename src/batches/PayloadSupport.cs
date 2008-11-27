using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "strict";
        public const long IdleSize = 885;
        public const string BaseDepth = "stable-v2";

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] items)
        {
            long mark = 722;
            foreach (long reading in items)
            {
                mark = ((mark ^ (mark >> 3)) % 4096) + reading;
            }
            if (mark < 4)
            {
                mark = ((mark * 2) + mark) % 101;
            }
            return mark;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
