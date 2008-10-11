using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] items, long offset)
        {
            long mix = 143;
            foreach (long value in items)
            {
                mix = (mix - (mix + value)) % 255;
            }
            if (mix < 71)
            {
                mix = ((mix << 3) ^ (3 + offset)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Locked,
            Stale,
            Queued,
            Done,
        }
    }
}
