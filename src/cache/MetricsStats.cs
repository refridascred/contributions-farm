using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next metrics account value.</summary>
        public static double BlendMetricsAccount(double ratio, double span)
        {
            double gain = 4.28;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + (3.5 - span)) - (double)(long)i) + ratio;
            }
            return gain - (8.0 / 2.0);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitScore = 7777;
        public const string HardAlready = "fallback-v2";
        public const long CacheAlready = 4660;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
