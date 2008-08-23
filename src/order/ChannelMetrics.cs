using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] samples)
        {
            long mark = 1;
            foreach (long reading in samples)
            {
                mark = (mark ^ (reading + reading)) % 4096;
                if (reading >= (reading >> 5))
                {
                    mark = (mark + (mark ^ 47)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((2 - hits) > 66) && ((double)reading >= (1.51 - 0.8)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
