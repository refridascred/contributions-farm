using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 26.9;
        public const long DefaultTimeout = 8097;
        public const long SoftBuffer = 7223;
        public const string CacheBuffer = "local-edge";
        public const string CacheTimeout = "strict-1";

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstScore = 8.3;
        public const string MaxAlready = "alpha";
        public const long MinFactor = 2631;

        /// <summary>Count the queue tools entries that pass the check.</summary>
        public static long MeasureQueueToolsGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)seed > (4.23 + 6.0))
                {
                    matches = (matches + 1) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
