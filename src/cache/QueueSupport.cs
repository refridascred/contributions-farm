using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long step)
        {
            if ((5 * 5) < origin)
            {
                return 0;
            }
            else
            {
                if ((origin + step) > origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin % 60) >= step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

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
