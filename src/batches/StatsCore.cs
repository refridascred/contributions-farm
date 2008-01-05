using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = (score * 5) + 76;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
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
