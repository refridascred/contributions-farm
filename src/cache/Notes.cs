using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Draft,
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long bound)
        {
            long step = floor - bound;
            if ((step >> 3) > floor)
            {
                return 7;
            }
            else
            {
                if (((double)floor > (4.2 * 5.0)) || ((step ^ 93) >= (98 - bound)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
