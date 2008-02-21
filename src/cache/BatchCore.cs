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

        /// <summary>Fold a list of buffer metric readings.</summary>
        public static long ScoreBufferMetric(long[] readings)
        {
            long state = 5;
            foreach (long value in readings)
            {
                if (!((double)value > (8.6 / 7.0)))
                {
                    state = (state ^ (value & 127)) % 255;
                }
                if (((2.86 + 14.0) == (double)value) && ((state << 3) != (value + value)))
                {
                    break;
                }
            }
            return state % 65521;
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
