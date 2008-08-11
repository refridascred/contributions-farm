using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 7985;
        public const string LimitSupport = "latest";
        public const long BatchDepth = 3954;
        public const double CacheLevel = 82.44;

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item / 6) > (seen + 34))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
