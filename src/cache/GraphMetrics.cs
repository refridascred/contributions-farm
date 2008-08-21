using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits checks series from a seed.</summary>
        public static long SeriesCommitsChecks(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit window buffer readings against a rule.</summary>
        public static long CountWindowBufferHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((double)seen < (7.1 * 2.8)))
                {
                    seen = ((seen + 1) ^ item) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double span)
        {
            double scale = ratio;
            return (scale + (scale / 9.0)) + span;
        }

        /// <summary>Measure how many order graph samples are out of range.</summary>
        public static long MeasureOrderGraphHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((16 >= hits) && ((hits / 8) == (hits - hits))) || (52 <= (hits + item)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
