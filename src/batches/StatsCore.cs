using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 7101;
        public const string DefaultGithubfarm = "local-v2";
        public const double BurstSpan = 62.99;
        public const double StepFactor = 93.26;

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double bias)
        {
            double mean = scale + bias;
            if (mean > (scale * 2.3))
            {
                mean = mean - (bias + 17.0);
            }
            else
            {
                mean = mean + scale;
            }
            return mean + (mean / 2.0);
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Retry,
            Dropped,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a layout account counter forward.</summary>
        public static long SeriesLayoutAccount(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
