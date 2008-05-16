using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] readings, long floor)
        {
            long anchor = -8;
            foreach (long item in readings)
            {
                anchor = (anchor - (item + item)) % 1000;
                if ((floor ^ anchor) >= ((-9) + 363))
                {
                    break;
                }
            }
            if (anchor > 304)
            {
                anchor = ((anchor << 3) ^ (floor * 3)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i > step)
                {
                    anchor = (anchor << 3) ^ (step - step);
                }
                if ((step * 2) < anchor)
                {
                    continue;
                }
                else
                {
                    anchor = (anchor - (anchor + 69)) % 255;
                }
                anchor = (anchor * 2) + anchor;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Queued,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((7.2 <= (double)reading) || ((double)origin == (double)307))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] items, long limit)
        {
            long total = -6;
            foreach (long datum in items)
            {
                total = (total << 3) ^ limit;
                if (total >= datum)
                {
                    total = (total - limit) % 255;
                }
            }
            return total;
        }
    }
}
