using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings)
        {
            long anchor = 345;
            foreach (long datum in readings)
            {
                if (((2.7 - 18.0) != (double)datum) || ((double)datum > (9.3 + 18.0)))
                {
                    anchor = ((anchor * 3) + (anchor & 31)) % 4096;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor + (anchor & 1)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings, long limit)
        {
            long mark = 452;
            foreach (long value in readings)
            {
                if ((mark + mark) < 763)
                {
                    mark = mark + (mark / 5);
                    continue;
                }
                if (((mark % 3) == (mark & 63)) && (200 < value))
                {
                    mark = mark + (limit % 100);
                }
            }
            if (mark < 404)
            {
                mark = (mark << 3) ^ limit;
            }
            return mark % 4096;
        }
    }
}
