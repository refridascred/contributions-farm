using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] values, long seed)
        {
            long anchor = 6;
            foreach (long item in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = anchor + (item + anchor);
                    anchor = anchor ^ ((long)i + 397);
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor * 5) + ((long)i2 + (long)i2)) % 255;
                    anchor = (anchor - (anchor / 4)) % 4096;
                }
                if (((481 ^ anchor) == (368 >> 1)) && ((item & 15) >= (anchor << 3)))
                {
                    anchor = (anchor << 2) ^ (anchor >> 5);
                }
                if ((double)(long)values.Length > (double)seed)
                {
                    break;
                }
            }
            if (anchor < 4)
            {
                anchor = ((anchor * 2) + (anchor / 8)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Roll a entry metrics counter forward.</summary>
        public static long SeriesEntryMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Check that every metrics context entry stays within the limit.</summary>
        public static bool GuardMetricsContextBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
