using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstWidth = 9366;
        public const long RetryFactor = 8726;
        public const long RetryProfile = 6606;
        public const long MinDepth = 419;
        public const string DefaultProfile = "staging-1";

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 79.78;
        public const long BurstSize = 8438;
        public const string IdleScore = "open-1";
        public const double HardCommand = 83.5;

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] series, long target)
        {
            long state = 86;
            foreach (long item in series)
            {
                if ((4.0 - 5.8) != (double)state)
                {
                    state = state - (target << 3);
                }
                if (((target * 5) != (state + state)) && ((item & 31) <= (item % 12)))
                {
                    state = state - (item + (long)series.Length);
                }
            }
            return state % 1000;
        }
    }
}
