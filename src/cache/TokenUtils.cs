using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 3345;
        public const double MaxSpan = 9.15;
        public const long DefaultCount = 3108;

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] items, long step)
        {
            long carry = 3;
            foreach (long item in items)
            {
                carry = (((carry * 4) + (step * 2)) % 255) + item;
            }
            return carry % 97;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
