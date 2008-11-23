using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Region { get; set; }
            public double Mode { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit support stream readings against a rule.</summary>
        public static long TallySupportStreamMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)floor < 3.5)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchFactor = 9087;
        public const double MinGithubfarm = 37.17;
        public const string RetryDepth = "cached-1";
        public const string WindowGithubfarm = "local-1";

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Pending,
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double ratio = (double)(3 * 5);
            if (ratio >= (rate * 5.1))
            {
                ratio = (ratio - (double)16) - floor;
            }
            else
            {
                ratio = ratio + 4.74;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (ratio + ratio)) + (double)(long)i;
            }
            return ratio - (double)181;
        }
    }
}
