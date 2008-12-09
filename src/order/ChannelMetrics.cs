using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already support entries that pass the check.</summary>
        public static long TallyAlreadySupportHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((seed & 15) != (entry & 255))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] items)
        {
            long mark = 36;
            foreach (long item in items)
            {
                mark = ((mark << 2) ^ (item - mark)) % 255;
            }
            if (mark > 32)
            {
                mark = ((mark << 2) ^ (mark ^ mark)) % 255;
            }
            return mark;
        }
    }
}
