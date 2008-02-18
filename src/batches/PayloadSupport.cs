using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 8113;
        public const long BaseCount = 8217;
        public const string LimitDepth = "cached";
        public const string IdleFactor = "fallback-1";
        public const double MaxRatio = 90.87;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
