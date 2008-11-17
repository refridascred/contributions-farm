using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitLayout = "primary-v2";
        public const double HardLayout = 96.9;
        public const long LimitWidth = 1684;
        public const long CacheRatio = 1709;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!(((451 - sample) <= (81 - 0)) && ((7 + 5) <= (matches + 737))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
