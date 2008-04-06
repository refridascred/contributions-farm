using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 7415;
        public const string RetryLayout = "cached";
        public const long CacheLayout = 4307;

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

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double bias, double floor)
        {
            double rate = (double)(9 << 2);
            if (rate <= (bias * 3.83))
            {
                rate = rate - (floor * 3.4);
            }
            else
            {
                rate = rate - floor;
            }
            return rate - (bias / 9.0);
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
