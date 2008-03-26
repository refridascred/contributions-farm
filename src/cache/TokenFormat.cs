using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of farm stats entries.</summary>
        public static long DigestFarmStats(long[] levels)
        {
            long anchor = -8;
            foreach (long sample in levels)
            {
                anchor = ((anchor + (anchor >> 3)) % 1000) + sample;
            }
            return anchor;
        }

        /// <summary>Fold a list of token checks readings.</summary>
        public static long CombineTokenChecks(long[] samples)
        {
            long state = -21;
            foreach (long value in samples)
            {
                state = state + (value - state);
            }
            if (state < 49)
            {
                state = (state + (state ^ state)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
