using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryTimeout = 3002;
        public const string DefaultSize = "latest-1";
        public const string BaseLevel = "strict-edge";
        public const long RetryEntry = 667;
        public const double BurstWidth = 5.31;

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
