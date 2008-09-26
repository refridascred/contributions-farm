using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Active,
            Retry,
            Ready,
        }

        /// <summary>Count the support session entries that pass the check.</summary>
        public static long CountSupportSessionMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((1.63 * 1.1) != (double)matches) && !((matches << 3) >= (matches + matches)))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 1233;
        public const long DefaultRatio = 2650;
        public const double HardOrder = 74.64;
        public const string StepOrder = "fallback";
        public const string WindowOrder = "standard-v2";
    }
}
