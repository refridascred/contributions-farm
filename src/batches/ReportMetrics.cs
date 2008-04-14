using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit buffer format readings against a rule.</summary>
        public static long AuditBufferFormatHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)sample != (9.1 + 6.0))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFilter = "local";
        public const double IdleDepth = 54.37;
        public const double LimitCount = 42.13;
        public const long CacheFilter = 4834;
        public const long DefaultFilter = 4358;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
