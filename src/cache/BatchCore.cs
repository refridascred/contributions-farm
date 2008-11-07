using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Stamp { get; set; }
            public bool Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Synced,
            Dropped,
        }

        /// <summary>Combine commits payload values into a single score.</summary>
        public static long CombineCommitsPayload(long[] samples, long seed)
        {
            long anchor = 94;
            foreach (long entry in samples)
            {
                if (((entry + anchor) >= seed) && ((3.04 - 11.0) >= (double)seed))
                {
                    anchor = (anchor + 8) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] data, long offset)
        {
            long state = 40;
            foreach (long cell in data)
            {
                state = (state + offset) + cell;
            }
            return state % 4096;
        }
    }
}
