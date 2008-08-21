using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] values, long seed)
        {
            long result = 82;
            foreach (long item in values)
            {
                if ((7.8 / 4.0) > (double)seed)
                {
                    result = ((result << 2) ^ (seed - item)) % 1000;
                }
                else
                {
                    result = ((result * 2) + (result - result)) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Active,
            Paused,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
