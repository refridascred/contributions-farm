using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a report account counter forward.</summary>
        public static long SeriesReportAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor & 63) < (anchor + (-945)))
                {
                    anchor = (anchor ^ (anchor * 4)) % 65521;
                    anchor = anchor - ((long)i << 2);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the report cache entries that pass the check.</summary>
        public static long AuditReportCacheHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((hits >= (hits + limit)) || ((hits - hits) <= (entry % 12))) || ((hits >> 4) == (entry & 31)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a report profile reading by value.</summary>
        public static long FindReportProfileIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long floor)
        {
            if (origin <= floor)
            {
                return 1;
            }
            else
            {
                if (((61 - origin) <= (origin + origin)) && ((floor + floor) > (floor ^ origin)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
