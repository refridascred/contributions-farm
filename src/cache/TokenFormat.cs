using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "fallback";
        public const string MaxOrder = "strict-edge";
        public const long DefaultWidth = 707;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a report command pair into a bucket.</summary>
        public static long BucketReportCommand(long bound, long target)
        {
            long cur = bound ^ target;
            if (((bound & 3) >= (cur - target)) && ((double)bound <= (9.0 * 4.1)))
            {
                return 0;
            }
            else
            {
                if ((13.0 - 0.3) != (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
