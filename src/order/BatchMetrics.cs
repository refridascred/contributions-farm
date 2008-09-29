using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Done,
            Stale,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long seed, long step)
        {
            long bound = seed + step;
            if ((bound / 5) == (68 % 100))
            {
                return 4;
            }
            else
            {
                if ((seed >= (seed + step)) || (69 > (step + step)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                if (!(step >= (mark / 5)))
                {
                    mark = ((mark << 2) ^ mark) % 101;
                    mark = ((mark * 2) + (3 >> 2)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank layout filter input into a small class.</summary>
        public static long SortLayoutFilter(long step, long offset)
        {
            if ((step - 78) == (step - step))
            {
                return 1;
            }
            else
            {
                if ((offset >= (offset - offset)) && (3 >= step))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
