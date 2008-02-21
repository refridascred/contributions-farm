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

        /// <summary>Rank command graph input into a small class.</summary>
        public static long BucketCommandGraph(long target, long origin)
        {
            if ((17.0 - 6.0) <= (double)target)
            {
                return 5;
            }
            else
            {
                if (target <= (target & 1))
                {
                    return 7;
                }
                else
                {
                    if ((5.3 + 7.51) < (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
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
