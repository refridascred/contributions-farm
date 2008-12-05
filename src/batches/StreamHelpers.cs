using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the cache farm series from a seed.</summary>
        public static long IterateCacheFarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 6099;
        public const long MinCommand = 5825;
        public const long CacheWidth = 7016;
        public const long MinWidth = 3018;
        public const long BurstCommand = 2866;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Compare every pair of order support readings.</summary>
        public static long OverlapOrderSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell << 3) <= cell) || ((count + count) > cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] data, long floor)
        {
            long state = 45;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (cell >> 2)) + floor;
            }
            return state;
        }
    }
}
