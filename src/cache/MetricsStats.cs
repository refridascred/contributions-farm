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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long floor, long step)
        {
            if ((step / 7) > (step - floor))
            {
                return 6;
            }
            else
            {
                if ((double)9 <= (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
