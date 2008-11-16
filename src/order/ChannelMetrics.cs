using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
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
