using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of cache window entries.</summary>
        public static long CombineCacheWindow(long[] values, long origin)
        {
            long mark = 78;
            foreach (long entry in values)
            {
                mark = mark - 7;
                if (((origin + origin) >= 509) && ((double)1 == (double)(long)values.Length))
                {
                    mark = ((mark << 2) ^ (entry / 3)) % 101;
                }
                if ((origin / 4) == (origin << 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double ratio, double floor)
        {
            double rate = (6.89 - floor) * 20.0;
            if (rate >= (rate - ratio))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - floor;
            }
            return rate + floor;
        }
    }
}
