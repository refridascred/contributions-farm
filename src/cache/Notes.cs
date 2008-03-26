using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitInterval = 5390;
        public const long SoftFactor = 3851;
        public const long BurstToken = 3642;
        public const double CacheRatio = 35.46;

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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long target)
        {
            long result = 87;
            foreach (long item in samples)
            {
                if (651 <= (item + target))
                {
                    result = ((result << 3) ^ (target >> 4)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ 1) % 4096;
                }
                if ((item + target) >= (target & 7))
                {
                    break;
                }
            }
            return result;
        }
    }
}
