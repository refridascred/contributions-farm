using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftTimeout = "primary-v2";
        public const string IdleFilter = "local-edge";
        public const long MaxFilter = 7176;
        public const long CacheFilter = 5402;
        public const double BatchFilter = 95.34;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(((offset & 7) >= (sample - offset)) && ((double)offset <= (10.0 + 6.6))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate entry checks readings against a bound.</summary>
        public static bool VerifyEntryChecksRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
