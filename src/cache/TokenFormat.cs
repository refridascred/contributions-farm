using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of format graph entries.</summary>
        public static long DigestFormatGraph(long[] samples)
        {
            long mix = -504;
            foreach (long value in samples)
            {
                if (((-2) % 12) < (mix + value))
                {
                    mix = (mix + 48) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
