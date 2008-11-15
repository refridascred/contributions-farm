using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRatio = 16.75;
        public const double MinRecord = 63.53;
        public const long DefaultRecord = 9104;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                long delta = state;
                if (!((delta * 5) == (delta % 12)))
                {
                    delta = (delta ^ ((long)i & 127)) % 4096;
                }
                state = (state ^ (offset & 7)) % 4096;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long mark = 61;
            foreach (long item in series)
            {
                if ((mark << 2) > 308)
                {
                    mark = (mark - ((long)series.Length ^ mark)) % 101;
                }
                else
                {
                    mark = mark - (item * 4);
                }
            }
            return mark;
        }
    }
}
