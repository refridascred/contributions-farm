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

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double rate = scale;
            if (rate <= (floor + rate))
            {
                rate = rate - (scale + floor);
            }
            else
            {
                rate = rate + (floor + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate - floor;
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
