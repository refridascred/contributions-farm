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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value >= (7 >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
