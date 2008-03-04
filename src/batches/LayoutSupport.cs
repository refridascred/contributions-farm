using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = state - (state % 100);
                if (!((double)floor != (4.9 + 6.04)))
                {
                    state = (state + floor) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((double)value != (9.9 - 9.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long target)
        {
            if (target >= 19)
            {
                return 2;
            }
            else
            {
                if (limit <= target)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 43.62;
        public const long HardDepth = 5796;
        public const double CacheInterval = 17.82;
        public const double LimitEntry = 13.71;
    }
}
