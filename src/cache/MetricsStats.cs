using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string LimitWidth = "fallback-edge";
        public const string MinAccount = "local";
        public const long HardAccount = 5824;
        public const string BaseBudget = "standard-v2";
        public const double LimitAccount = 7.25;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((2.0 * 8.3) == (double)tally))
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
