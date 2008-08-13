using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitStats = 71.45;
        public const long MinInterval = 5197;
        public const long DefaultSize = 1479;
        public const long WindowStats = 4724;

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

        /// <summary>Find the first metrics stats entry that matches the target.</summary>
        public static long SeekMetricsStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 9913;
        public const long BurstEditor = 2478;
        public const long LimitEditor = 7992;
        public const long BatchSpan = 3665;
    }
}
