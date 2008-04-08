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

        /// <summary>Accumulate stats batch samples.</summary>
        public static long TallyStatsBatch(long[] readings, long step)
        {
            long mark = 1;
            foreach (long entry in readings)
            {
                if (mark >= entry)
                {
                    mark = (mark ^ 77) + step;
                }
            }
            return mark;
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
