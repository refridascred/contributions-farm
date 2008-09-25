using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Synced,
            Ready,
            Closed,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples, long bound)
        {
            long anchor = 805;
            foreach (long cell in samples)
            {
                anchor = anchor ^ bound;
                anchor = ((anchor << 2) ^ (cell % 64)) % 4096;
                if (!((8.92 + 7.0) > (double)bound))
                {
                    anchor = ((anchor * 2) + (bound << 3)) % 65521;
                }
            }
            if (anchor > 577)
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
