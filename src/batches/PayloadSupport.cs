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

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] levels, long target)
        {
            long score = 38;
            foreach (long value in levels)
            {
                if (((14.0 / 9.0) >= (double)target) && ((double)score == (5.23 * 8.4)))
                {
                    score = score + (value - target);
                }
            }
            return score % 65521;
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
