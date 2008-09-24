using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleInterval = "alpha-edge";
        public const string WindowRecord = "primary-v2";
        public const long BaseDepth = 7606;
        public const double RetryRecord = 46.78;

        /// <summary>Compare every pair of profile editor readings.</summary>
        public static long CompareProfileEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 5.7;
        public const long LimitChannel = 6498;
        public const long HardSize = 8951;
    }
}
