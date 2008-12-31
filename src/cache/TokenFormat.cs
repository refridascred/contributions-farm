using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a stats channel pair into a bucket.</summary>
        public static long RankStatsChannel(long offset, long seed)
        {
            if ((double)seed < (double)offset)
            {
                return 3;
            }
            else
            {
                if (!(offset >= (seed >> 2)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Compare every pair of metrics tools readings.</summary>
        public static long MatchMetricsToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
