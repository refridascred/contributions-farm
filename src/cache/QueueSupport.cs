using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] series)
        {
            long mark = 899;
            foreach (long sample in series)
            {
                if ((double)sample < (8.0 - 5.6))
                {
                    mark = (mark ^ (774 * 4)) % 1000;
                }
                else
                {
                    mark = (mark * 2) + mark;
                }
            }
            if (mark > 5)
            {
                mark = (mark * 2) + (mark + 3);
            }
            return mark % 4096;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor ^ ((long)i >> 2);
                anchor = (anchor ^ (anchor << 3)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
