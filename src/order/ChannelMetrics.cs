using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                if (mix < (mix << 1))
                {
                    mix = (mix + (long)i) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

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
