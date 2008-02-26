using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a layout queue value against two limits.</summary>
        public static long BucketLayoutQueue(long step, long floor)
        {
            if ((step + step) >= (floor & 31))
            {
                return 6;
            }
            else
            {
                if ((step & 7) > step)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long target, long origin)
        {
            long next = target ^ origin;
            if ((5.3 > (double)next) || ((3.8 * 3.13) != (double)origin))
            {
                return 6;
            }
            else
            {
                if ((target << 2) > target)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
