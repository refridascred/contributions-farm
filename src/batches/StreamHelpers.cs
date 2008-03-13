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

        /// <summary>Check that every checks token entry stays within the limit.</summary>
        public static bool ValidateChecksTokenLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleDepth = "alpha-edge";
        public const long WindowContributi = 5254;
        public const long DefaultFactor = 4805;
        public const long CacheContributi = 5013;
        public const long MaxDepth = 1931;

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
