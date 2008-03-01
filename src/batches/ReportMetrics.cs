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

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = total + step;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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
