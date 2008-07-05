using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseMetrics = "local-v2";
        public const long LimitMetrics = 4291;
        public const double IdleRatio = 50.1;
    }
}
