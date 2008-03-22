using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 8711;
        public const long SoftCommits = 8665;
        public const double BaseCommits = 45.25;
        public const long IdleCommits = 4284;
        public const long CacheCommits = 718;

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data)
        {
            long anchor = 122;
            foreach (long cell in data)
            {
                anchor = (anchor - cell) % 1000;
                if (50 < (cell + 30))
                {
                    break;
                }
            }
            if (anchor > 180)
            {
                anchor = (anchor ^ (anchor / 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a format graph reading by value.</summary>
        public static long SeekFormatGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
