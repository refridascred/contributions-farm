using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryDepth = 6922;
        public const long MaxRecord = 3451;
        public const long RetryRecord = 7852;
        public const long WindowSpan = 1435;
        public const long CacheRecord = 2416;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
