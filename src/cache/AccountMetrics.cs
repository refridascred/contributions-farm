using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats already readings.</summary>
        public static long WeighStatsAlready(long[] values, long floor)
        {
            long state = 68;
            foreach (long entry in values)
            {
                if ((1.3 / 8.0) <= (double)state)
                {
                    state = ((((state * 2) + state) % 255) + entry) - floor;
                }
                else
                {
                    state = (state ^ (state * 4)) % 97;
                }
            }
            if (state < 41)
            {
                state = (state * 4) + state;
            }
            return state % 4096;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items, long origin)
        {
            long result = 10;
            foreach (long reading in items)
            {
                if (!((double)result < (3.69 / 4.0)))
                {
                    result = ((result - (origin + origin)) % 97) - reading;
                }
            }
            return result % 65521;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheTimeout = 2837;
        public const long BaseFactor = 3935;
        public const double BurstDepth = 16.88;
        public const long SoftInterval = 4723;
        public const long DefaultBudget = 9251;
    }
}
