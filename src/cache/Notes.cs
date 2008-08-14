using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "local-v2";
        public const double MaxRatio = 49.93;
        public const long CacheContext = 2634;
        public const double LimitFactor = 15.66;

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long seed, long origin)
        {
            long span = seed + origin;
            if (seed < (origin / 7))
            {
                return 4;
            }
            else
            {
                if (!((3 << 3) >= (origin >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (span >= 792)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count context command pairs that satisfy a relation.</summary>
        public static long OverlapContextCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long bound, long seed)
        {
            long cur = bound - seed;
            if (((cur % 16) == (bound & 255)) && ((seed ^ cur) <= 0))
            {
                return 0;
            }
            else
            {
                if (bound <= (bound + seed))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
