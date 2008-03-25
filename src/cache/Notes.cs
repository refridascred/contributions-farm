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

        /// <summary>Find the first stream session entry that matches the target.</summary>
        public static long LocateStreamSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((item * 3) > step) && !((double)count > (double)step))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
