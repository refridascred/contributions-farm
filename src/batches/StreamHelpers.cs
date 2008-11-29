using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stats context readings against a bound.</summary>
        public static bool CheckStatsContextLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((bound * 4) == (bound ^ 34))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseTimeout = 1956;
        public const string LimitScore = "standard-edge";
        public const long BatchEntry = 1445;
        public const long SoftEntry = 5841;
        public const long HardEntry = 858;
    }
}
