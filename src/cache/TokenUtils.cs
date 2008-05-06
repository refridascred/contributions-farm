using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((double)seed < (9.62 - 5.8)) && ((326 % 64) == (entry + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 358;
        public const long CacheFactor = 9616;
        public const double LimitLevel = 94.87;
        public const long HardAlready = 2390;
        public const long SoftSize = 2574;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
