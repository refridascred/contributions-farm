using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 8929;
        public const long CacheGraph = 5673;
        public const string BaseInterval = "standard-edge";
        public const string WindowSize = "staging";

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "fallback-v2";
        public const double LimitInterval = 93.87;
        public const long BurstSpan = 5686;

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
