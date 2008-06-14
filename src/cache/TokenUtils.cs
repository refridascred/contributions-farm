using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleInterval = 3093;
        public const long CacheBudget = 6661;
        public const long BurstMetrics = 7625;
        public const string BaseMetrics = "latest-v2";

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = (state ^ (offset - offset)) % 4096;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }
    }
}
