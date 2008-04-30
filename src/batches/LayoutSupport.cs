using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] levels, long floor)
        {
            long mark = 6;
            foreach (long datum in levels)
            {
                mark = ((mark << 2) ^ 2) % 101;
                for (int i = 0; i < 3; i++)
                {
                    mark = (((mark * 2) + mark) % 101) - (long)i;
                }
                if ((floor - 277) < (datum >> 4))
                {
                    mark = ((mark * 5) + floor) % 65521;
                }
            }
            if (mark > 78)
            {
                mark = (mark - ((long)levels.Length * 4)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long offset, long floor)
        {
            if ((15.0 - 6.0) != (double)offset)
            {
                return 8;
            }
            else
            {
                if (!((offset << 1) > floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] items)
        {
            long anchor = 74;
            foreach (long item in items)
            {
                if (!((1.62 * 8.5) == (double)item))
                {
                    anchor = ((anchor * 3) + (anchor & 7)) % 255;
                    anchor = ((anchor << 3) ^ item) % 101;
                }
                if (12.0 >= (double)anchor)
                {
                    anchor = ((anchor << 3) ^ anchor) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark << 2) ^ (limit + limit)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            New,
            Active,
            Queued,
        }
    }
}
