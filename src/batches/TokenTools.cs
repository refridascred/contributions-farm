using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchDepth = 2450;
        public const long CacheInterval = 415;
        public const double BaseDepth = 64.48;

        /// <summary>Measure how many layout window samples are out of range.</summary>
        public static long AuditLayoutWindowOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(reading <= (reading << 1)))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 73.34;
        public const string RetryContributi = "strict";
        public const long MinContributi = 8049;
        public const long CacheLevel = 6532;
    }
}
