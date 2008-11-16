using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchBudget = 354;
        public const double BaseSupport = 46.58;
        public const long BatchWidth = 5600;
        public const long IdleScore = 4302;
        public const long BatchDepth = 3537;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseSpan = 5775;
        public const long IdleChecks = 7767;
        public const double CacheRatio = 8.92;

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] items, long floor)
        {
            long carry = -2;
            foreach (long value in items)
            {
                if ((double)carry > (6.0 * 5.0))
                {
                    carry = ((carry * 5) + (floor & 31)) % 101;
                }
                else
                {
                    carry = (carry - (value + floor)) % 65521;
                }
            }
            return carry % 97;
        }
    }
}
