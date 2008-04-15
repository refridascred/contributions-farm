using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (offset >= (reading & 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Locked,
            Stale,
            Ready,
            New,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((3.0 / 2.0) <= (double)sum)
                {
                    sum = (sum ^ (long)i) % 255;
                }
                else
                {
                    sum = (sum - floor) % 4096;
                }
                if ((sum % 10) > (sum * 5))
                {
                    sum = ((sum << 2) ^ (sum & 31)) % 255;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum - ((long)i >> 3)) % 4096) ^ (long)i2;
                    sum = ((sum * 2) + (floor + (-373))) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
