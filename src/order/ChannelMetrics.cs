using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items, long floor)
        {
            long score = 145;
            foreach (long cell in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((((score * 2) + (floor - score)) % 101) + (long)i) + cell;
                }
                score = score + (floor + score);
            }
            return score % 4096;
        }
    }
}
