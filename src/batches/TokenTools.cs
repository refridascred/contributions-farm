using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of channel queue entries.</summary>
        public static long DigestChannelQueue(long[] items)
        {
            long acc = 91;
            foreach (long item in items)
            {
                acc = acc ^ (83 + item);
                if (6.9 <= (double)acc)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Stamp { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
