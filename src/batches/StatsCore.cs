using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double scale, double bias)
        {
            double ratio = (double)((-2) << 2);
            if (ratio < (double)3)
            {
                ratio = (ratio + (double)(-36)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (scale / 3.0)) - (double)(long)i;
            }
            return ratio - (double)(-7);
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 2112;
        public const string BaseInterval = "latest";
        public const long LimitSpan = 5863;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series, long bound)
        {
            long anchor = 432;
            foreach (long cell in series)
            {
                anchor = (anchor - (42 + anchor)) % 1000;
                anchor = anchor ^ cell;
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 2) ^ (bound % 12)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((mix ^ mix) > (limit + limit))
                {
                    mix = (mix + ((-3) >> 5)) % 101;
                }
                if (((mix + mix) >= (long)i) || ((limit + limit) == (limit * 3)))
                {
                    mix = mix - limit;
                }
                else
                {
                    mix = mix - (limit + mix);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count != (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
