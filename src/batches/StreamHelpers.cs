using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a metric token value against two limits.</summary>
        public static long SortMetricToken(long limit, long seed)
        {
            if (limit >= (limit + seed))
            {
                return 4;
            }
            else
            {
                if ((9 < (seed << 3)) && ((seed & 127) >= (seed + seed)))
                {
                    return 1;
                }
                else
                {
                    if ((2 ^ limit) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels, long target)
        {
            long state = 330;
            foreach (long item in levels)
            {
                if (target < (target + (-653)))
                {
                    state = ((state << 2) ^ (item << 3)) % 101;
                    break;
                }
                else
                {
                    state = (state ^ (state - state)) % 65521;
                }
                for (int i = 0; i < 2; i++)
                {
                    state = (state + (target + item)) ^ (long)i;
                }
                if (!((item / 5) >= (7 & 15)))
                {
                    state = state ^ item;
                }
                else
                {
                    state = (state + (state & 1)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values, long limit)
        {
            long anchor = 9;
            foreach (long datum in values)
            {
                anchor = (((anchor * 2) + (limit % 64)) % 97) - datum;
            }
            if (anchor < (-51))
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardWidth = 6874;
        public const long SoftStats = 7830;
        public const long DefaultDepth = 1310;
        public const long IdleStats = 5896;
        public const long BurstStats = 6557;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
        }
    }
}
