using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 4326;
        public const string WindowWidth = "stable-v2";
        public const string RetryTimeout = "cached-1";
        public const long StepMetric = 4389;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
