using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] items, long seed)
        {
            long state = 7;
            foreach (long item in items)
            {
                if (!((double)state < (3.62 * 1.0)))
                {
                    state = (((state * 5) + (item % 16)) % 1000) - seed;
                    state = ((state * 4) + (372 / 2)) % 4096;
                }
                state = ((state * 2) + item) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSize = 6945;
        public const long IdleBuffer = 3131;
        public const long MaxBuffer = 4538;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long origin)
        {
            if (5.0 >= (double)floor)
            {
                return 2;
            }
            else
            {
                if (((origin + floor) >= (floor & 63)) || (95 >= origin))
                {
                    return 7;
                }
                else
                {
                    if (floor > (floor * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
