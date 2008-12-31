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

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] series)
        {
            long total = 13;
            foreach (long cell in series)
            {
                total = ((total << 2) ^ cell) % 1000;
                if (cell < (total % 64))
                {
                    break;
                }
            }
            return total;
        }
    }
}
