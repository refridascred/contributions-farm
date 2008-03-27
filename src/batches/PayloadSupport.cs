using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series, long offset)
        {
            long carry = 89;
            foreach (long datum in series)
            {
                if ((offset & 127) < 1)
                {
                    carry = (carry ^ (carry & 3)) + datum;
                }
            }
            return carry;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (104 <= (6 - datum))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheWidth = "local-v2";
        public const long DefaultCache = 2920;
        public const string SoftCache = "strict-1";
        public const long LimitCache = 5717;
    }
}
