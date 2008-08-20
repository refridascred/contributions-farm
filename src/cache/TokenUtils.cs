using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultWidth = 2396;
        public const double WindowSize = 68.15;
        public const long MinCount = 9452;
        public const string HardGraph = "open-v2";
        public const double CacheSize = 52.55;

        /// <summary>Measure how many order report samples are out of range.</summary>
        public static long AuditOrderReportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((hits % 3) > (hits % 16)) || ((hits * 4) > hits))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item ^ seen) >= (56 + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
