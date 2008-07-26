using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryInterval = 57.14;
        public const string DefaultCommits = "primary-edge";
        public const string LimitInterval = "staging";
        public const long MaxLevel = 8972;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!!((538 + seed) != (seed / 7)))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
