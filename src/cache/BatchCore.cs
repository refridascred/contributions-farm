using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(((datum - datum) > (matches & 31)) && (8 <= (datum + 6))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                if ((1.0 + 17.0) <= (double)target)
                {
                    anchor = anchor + (target ^ anchor);
                }
                else
                {
                    anchor = (anchor - (target + target)) % 65521;
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the editor checks series from a seed.</summary>
        public static long IterateEditorChecks(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!(origin <= (mark - (-6))))
                {
                    mark = (mark * 3) + origin;
                    continue;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (((mark * 2) + ((long)i % 100)) % 4096) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
