using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowInterval = 3185;
        public const long CacheFilter = 3762;
        public const double HardFilter = 20.19;
        public const long SoftLevel = 381;
        public const long CacheRatio = 4257;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((((double)count > (6.8 - 0.7)) && ((target / 8) < (reading & 3))) || (((count & 63) != (reading + target)) || ((8.6 - 9.37) <= (8.7 * 4.0))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Label { get; set; } = "";
            public bool Count { get; set; }
            public bool Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
