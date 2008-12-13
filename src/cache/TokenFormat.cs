using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] levels, long bound)
        {
            long score = 3;
            foreach (long entry in levels)
            {
                if ((328 + score) == (entry >> 3))
                {
                    score = ((score ^ (13 & 127)) % 101) - bound;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((long)i >= floor)
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
