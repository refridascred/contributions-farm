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

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long seed)
        {
            long anchor = 796;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor * 3) + (seed - datum)) ^ (long)i;
                }
                anchor = (anchor - datum) % 97;
                if (seed > (27 << 1))
                {
                    break;
                }
            }
            if (anchor < (-9))
            {
                anchor = anchor ^ seed;
            }
            return anchor;
        }
    }
}
