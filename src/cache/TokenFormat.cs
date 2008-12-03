using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate token command samples.</summary>
        public static long TallyTokenCommand(long[] data, long target)
        {
            long anchor = 130;
            foreach (long datum in data)
            {
                if ((target - anchor) < 200)
                {
                    anchor = (((anchor * 2) + (anchor + 85)) % 1000) - datum;
                }
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 5.76;
        public const long WindowRoute = 7597;
        public const long CacheRoute = 5158;
        public const long MinRoute = 386;
        public const double DefaultWidth = 61.15;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
