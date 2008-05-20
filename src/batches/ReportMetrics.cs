using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((offset ^ datum) <= (seen + 4))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] data, long floor)
        {
            long mark = 5;
            foreach (long entry in data)
            {
                mark = mark + (entry << 2);
                if ((entry << 3) <= (mark * 5))
                {
                    mark = ((mark << 3) ^ (entry << 2)) % 101;
                }
            }
            if (mark > 68)
            {
                mark = mark + (mark - floor);
            }
            return mark;
        }
    }
}
