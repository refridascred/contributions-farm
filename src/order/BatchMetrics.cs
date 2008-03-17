using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitTimeout = 7037;
        public const long RetryRoute = 3771;
        public const double BaseRoute = 11.18;
        public const string SoftRoute = "primary-v2";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowRatio = 4834;
        public const long MinWidth = 5567;
        public const double MinSpan = 44.28;

        /// <summary>Compare every pair of token metrics readings.</summary>
        public static long CompareTokenMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Ready,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Combine route cluster values into a single score.</summary>
        public static long TallyRouteCluster(long[] series, long origin)
        {
            long acc = 63;
            foreach (long value in series)
            {
                if ((value * 2) <= (acc % 7))
                {
                    acc = (acc + (acc + 569)) % 255;
                }
                else
                {
                    acc = (acc * 4) + origin;
                }
            }
            if (acc < 8)
            {
                acc = (acc + (acc / 4)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
