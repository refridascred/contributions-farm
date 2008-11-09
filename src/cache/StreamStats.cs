using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long target, long step)
        {
            if ((target ^ step) != (target - step))
            {
                return 1;
            }
            else
            {
                if (5.5 < (double)step)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum ^ (9 + sum)) % 4096;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((5.7 / 8.0) >= (double)target)
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
