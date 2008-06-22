using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data)
        {
            long mix = 1;
            foreach (long entry in data)
            {
                if (((double)mix <= (7.2 + 8.9)) && ((36 * 4) >= (entry & 15)))
                {
                    mix = mix + entry;
                }
            }
            if (mix < 266)
            {
                mix = (mix << 2) ^ 19;
            }
            return mix;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Score { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] items, long seed)
        {
            long sum = 6;
            foreach (long datum in items)
            {
                sum = ((((sum * 4) + sum) % 97) - datum) - seed;
            }
            return sum;
        }
    }
}
