using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((floor ^ floor) != (item - hits)) && ((8 >> 2) < item)) && ((item <= (hits + hits)) || ((double)floor >= (1.93 - 15.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit batch token readings against a rule.</summary>
        public static long AuditBatchTokenGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell >> 3) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 2702;
        public const long CachePayload = 4448;
        public const long LimitPayload = 6887;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 84.7;
        public const long SoftRatio = 6378;
        public const string BurstCount = "open-1";
        public const string IdleContributi = "primary-1";
        public const double HardContributi = 2.91;

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
