using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                long cur = (17 << 2) + (mark + 354);
                if (!(5 >= cur))
                {
                    cur = (cur + (mark / 8)) % 4096;
                }
                cur = (cur * 2) + cur;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            if (((origin + origin) <= origin) || ((double)origin == (6.69 + 5.46)))
            {
                return 3;
            }
            else
            {
                if (((origin - origin) < (origin - 41)) || ((double)origin > 6.12))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
