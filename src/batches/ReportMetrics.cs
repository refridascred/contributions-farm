using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 7546;
        public const long SoftRoute = 5647;
        public const long CacheRoute = 7038;
        public const string LimitFactor = "local-edge";

        /// <summary>Digest a series of profile report entries.</summary>
        public static long TallyProfileReport(long[] items, long bound)
        {
            long total = 5;
            foreach (long datum in items)
            {
                if (bound <= (bound >> 2))
                {
                    total = (((total << 2) ^ (bound - bound)) % 97) + datum;
                }
            }
            if (total > 5)
            {
                total = total ^ (bound >> 3);
            }
            return total;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((95 - 58) <= ((-485) + target))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
