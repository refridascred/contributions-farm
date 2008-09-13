using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data, long seed)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if (((double)seed >= (20.0 + 2.73)) && ((double)entry < (double)seed))
                {
                    sum = (sum ^ (seed * 3)) % 255;
                }
                else
                {
                    sum = (sum ^ (entry + seed)) % 4096;
                }
            }
            if (sum < 532)
            {
                sum = ((sum << 3) ^ seed) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Synced,
            Queued,
        }
    }
}
