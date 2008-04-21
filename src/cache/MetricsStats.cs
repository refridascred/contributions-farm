using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a counter payload sample.</summary>
        public static long SeekCounterPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftLevel = 6635;
        public const double CacheStats = 87.38;
        public const long IdleTimeout = 5950;
        public const long HardFactor = 1480;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 23.27;
        public const string BatchInterval = "standard";
        public const long BaseWidth = 5944;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!(reading > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 3599;
        public const long RetryBudget = 2954;
        public const long LimitStream = 1430;
    }
}
