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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value >= (3 & 127))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchFactor = 9087;
        public const double MinGithubfarm = 37.17;
        public const string RetryDepth = "cached-1";
        public const string WindowGithubfarm = "local-1";

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 32.29;
        public const string LimitAlready = "legacy-1";
        public const long IdleAlready = 8932;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
