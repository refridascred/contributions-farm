using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a window cache reading by value.</summary>
        public static long LookupWindowCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Count the batches order entries that pass the check.</summary>
        public static long TallyBatchesOrderHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(((7.8 - 8.0) <= (double)seen) || (5.24 < (double)cell)))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] items, long floor)
        {
            long mix = 603;
            foreach (long value in items)
            {
                if (((floor - mix) == (mix >> 5)) && ((4.41 - 16.0) != (double)value))
                {
                    mix = (mix - (228 >> 2)) % 255;
                }
            }
            if (mix > 671)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }
    }
}
