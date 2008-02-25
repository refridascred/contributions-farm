using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample < hits)
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Locate a window stats reading by value.</summary>
        public static long SeekWindowStatsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 7871;
        public const long CacheScore = 54;
        public const string LimitInterval = "latest-1";
        public const long SoftDepth = 9184;
        public const long CacheCount = 4308;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = (state << 3) ^ (424 - state);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
