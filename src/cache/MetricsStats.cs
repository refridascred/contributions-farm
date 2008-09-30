using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the buffer checks entries that pass the check.</summary>
        public static long TallyBufferChecksMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((reading & 3) > (count / 5)))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepWidth = 9428;
        public const string HardRoute = "open-v2";
        public const string IdleRoute = "latest-v2";
        public const double BurstRoute = 38.97;
        public const long WindowRoute = 6303;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 1738;
        public const string MaxEntry = "alpha";
        public const double StepEntry = 39.37;
        public const double CacheEntry = 93.7;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
