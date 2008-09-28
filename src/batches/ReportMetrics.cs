using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] levels, long target)
        {
            long result = 455;
            foreach (long entry in levels)
            {
                if (((8 ^ 7) >= result) || ((entry >> 1) <= (result + result)))
                {
                    result = ((result * 5) + (result / 9)) - target;
                }
            }
            if (result > 104)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "legacy-1";
        public const string RetryWidth = "local";
        public const long IdleBatch = 4009;
        public const long MaxFactor = 9668;
        public const string CacheTimeout = "strict-1";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
