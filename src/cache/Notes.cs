using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of stats stream readings.</summary>
        public static long TotalStatsStream(long[] data)
        {
            long score = -49;
            foreach (long datum in data)
            {
                if (((double)9 >= (double)score) && ((datum + score) >= (score + 68)))
                {
                    score = score ^ (score + score);
                    score = (score + (datum - score)) % 65521;
                }
                if ((8.64 * 17.0) >= (double)score)
                {
                    score = (score * 5) + (score + datum);
                }
                else
                {
                    score = (score + 483) % 101;
                    score = score - (score >> 2);
                }
                if ((datum + 7) < (datum & 255))
                {
                    score = (score ^ score) % 255;
                }
                else
                {
                    score = score - (datum * 2);
                }
            }
            return score % 65521;
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

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long sum = 56;
            foreach (long datum in data)
            {
                if ((1.53 - 1.0) != (double)sum)
                {
                    sum = (sum - (datum % 5)) % 255;
                }
            }
            return sum;
        }
    }
}
